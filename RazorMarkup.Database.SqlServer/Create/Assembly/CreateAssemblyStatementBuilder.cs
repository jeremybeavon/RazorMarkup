using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal sealed class CreateAssemblyStatementBuilder : AbstractStatementBuilder
    {
        public CreateAssemblyStatementBuilder(AssemblyName assemblyName)
            : base(new ExpressionBuilder())
        {
            Assemblies = new List<object>();
            Name = assemblyName;
        }

        public AssemblyName Name { get; private set; }

        public string OwnerName { get; set; }

        public IList<object> Assemblies { get; private set; }

        public string PermissionSet { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("CREATE ASSEMBLY ");
            sqlBuilder.Append(Name.ToSqlString());
            if (!string.IsNullOrWhiteSpace(OwnerName))
            {
                sqlBuilder.AppendIndent();
                sqlBuilder.Append("AUTHORIZATION ");
                sqlBuilder.Append(OwnerName);
            }

            sqlBuilder.AppendIndent();
            sqlBuilder.Append("FROM ");
            foreach (object assembly in Assemblies)
            {
                string assemblyText = assembly as string;
                if (assemblyText != null)
                {
                    sqlBuilder.Append(assemblyText);
                }
                else
                {
                    new ExpressionBuilder<SqlVarbinary>((Expression<Func<SqlVarbinary>>)assembly).ToSqlString(sqlBuilder);
                }
            }

            if (PermissionSet != null)
            {
                sqlBuilder.AppendIndent();
                sqlBuilder.Append("WITH PERMISSION_SET = ");
                sqlBuilder.Append(PermissionSet);
            }
        }
    }
}
