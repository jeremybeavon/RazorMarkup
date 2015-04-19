using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class CodeGenerator
    {
        private static readonly IDictionary<string, string> systemTypes =
            typeof(Sql).Assembly.GetTypes()
            .Where(type => type.Namespace == "RazorMarkup.Database.SqlServer.Types" && type.Name.StartsWith("Sql"))
            .Select(type => type.Name)
            .ToDictionary(type => type.ToLower());
        private readonly string namespaceName;
        private readonly string objectType;
        private readonly bool isSystem;
        private readonly string outputDirectory;
        private IDisposable namespaceIndent;
        private IDisposable classIndent;
        private string currentSchemaName;
        private string currentObjectName;
        private TextBuilder currentClass;

        private CodeGenerator(string namespaceName, string objectType, bool isSystem, string outputDirectory)
        {
            this.namespaceName = namespaceName;
            this.objectType = objectType;
            this.isSystem = isSystem;
            this.outputDirectory = outputDirectory;
        }

        private static string SystemViewQuery
        {
            get
            {
                return @"
                    SELECT schemas.name, system_views.name, system_columns.name, types.name
                    FROM sys.schemas
                    INNER JOIN sys.system_views ON schemas.schema_id = system_views.schema_id
                    INNER JOIN sys.system_columns ON system_columns.object_id = system_views.object_id
                    INNER JOIN sys.types ON types.user_type_id = system_columns.user_type_id
                    ORDER BY schemas.name, system_views.name, system_columns.name";
                /*return Sql.Query().Select()
                    .Column(new ColumnName("schemas.name")).And()
                    .Column(new ColumnName("system_views.name")).And()
                    .Column(new ColumnName("system_columns.name")).And()
                    .Column(new ColumnName("types.name"))
                    .From().View(new ViewName("sys.schemas"))
                    .InnerJoin().View(new ViewName("sys.system_views"))
                    .On(() => new ColumnName("schemas.schema_id") == new ColumnName("system_views.schema_id"))
                    .InnerJoin().View(new ViewName("sys.system_columns"))
                    .On(() => new ColumnName("system_views.object_id") == new ColumnName("system_columns.object_id"))
                    .InnerJoin().View(new ViewName("sys.types"))
                    .On(() => new ColumnName("system_columns.user_type_id") == new ColumnName("types.user_type_id"))
                    .OrderBy(() => new ColumnName("schemas.name"))
                    .And(() => new ColumnName("system_views.name"))
                    .And(() => new ColumnName("system_columns.column_id"))
                    .End().Query().ToSqlString();*/
            }
        }

        public static void GenerateSystemViews(string connectionString, string namespaceName, string outputDirectory)
        {
            new CodeGenerator(namespaceName, "ViewName", true, outputDirectory).GenerateCode(connectionString, SystemViewQuery);
        }

        private static string GenerateName(string name)
        {
            return Regex.Replace(name.ToLower(), "(?:^|_)(?<Char>[a-z])", match => match.Groups["Char"].Value.ToUpper());
        }

        private static string GenerateType(string type)
        {
            if (type == "sql_variant")
            {
                return "SqlVariant";
            }

            return systemTypes["sql" + type];
        }

        private void GenerateCode(string connectionString, string commandText)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GenerateColumn(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }
        }

        private void GenerateColumn(string schemaName, string objectName, string columnName, string type)
        {
            if (schemaName != currentSchemaName || objectName != currentObjectName)
            {
                GenerateFile();
                currentSchemaName = schemaName;
                currentObjectName = objectName;
                currentClass = new TextBuilder();
                GenerateClassStart(schemaName, objectName);
            }

            currentClass.AppendIndent();
            currentClass.AppendIndent();
            const string columnDeclaration = "public static readonly Column<{0}> {1} = new Column<{0}>(\"{2}\");";
            currentClass.Append(string.Format(columnDeclaration, GenerateType(type), GenerateName(columnName), columnName));
        }

        private void GenerateFile()
        {
            if (currentClass != null)
            {
                string file = Path.Combine(outputDirectory, GenerateName(currentObjectName) + ".cs");
                if (!File.Exists(file))
                {
                    GenerateClassEnd();
                    File.WriteAllText(file, currentClass.ToString());
                }
            }
        }

        private void GenerateClassStart(string schemaName, string objectName)
        {
            currentClass = new TextBuilder();
            GenerateUsingStatements();
            currentClass.Append("namespace " + namespaceName);
            currentClass.AppendIndent();
            currentClass.Append("{");
            namespaceIndent = currentClass.IncrementIndent();
            currentClass.AppendIndent();
            currentClass.Append("public sealed class " + GenerateName(objectName));
            currentClass.AppendIndent();
            currentClass.Append("{");
            classIndent = currentClass.IncrementIndent();
            currentClass.AppendIndent();
            currentClass.Append(string.Format("public static readonly {0} {0} = new {0}(\"{1}.{2}\");", objectType, schemaName, objectName));
        }

        private void GenerateUsingStatements()
        {
            if (!isSystem)
            {
                currentClass.Append("using RazorMarkup.Database.SqlServer;");
                currentClass.AppendIndent();
            }

            currentClass.Append("using RazorMarkup.Database.SqlServer.Types;");
            currentClass.AppendIndent();
            currentClass.AppendIndent();
        }

        private void GenerateClassEnd()
        {
            classIndent.Dispose();
            currentClass.AppendIndent();
            currentClass.Append("}");
            namespaceIndent.Dispose();
            currentClass.AppendIndent();
            currentClass.Append("}");
            currentClass.AppendIndent();
        }
    }
}

/*
SELECT parm.name AS Parameter,        
typ.name AS [Type]
FROM sys.all_objects sp
JOIN sys.all_parameters parm ON sp.object_id = parm.object_id
JOIN sys.types typ ON parm.system_type_id = typ.system_type_id
WHERE sp.name = 'sp_MSmergeupdatelastsyncinfo'
*/