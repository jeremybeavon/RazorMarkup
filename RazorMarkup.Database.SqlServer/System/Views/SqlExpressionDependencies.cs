using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlExpressionDependencies
    {
        public static readonly ViewName ViewName = new("sys.sql_expression_dependencies");

        public static readonly Column<SqlBit> IsAmbiguous = new("is_ambiguous");

        public static readonly Column<SqlBit> IsCallerDependent = new("is_caller_dependent");

        public static readonly Column<SqlBit> IsSchemaBoundReference = new("is_schema_bound_reference");

        public static readonly Column<SqlTinyInt> ReferencedClass = new("referenced_class");

        public static readonly Column<SqlNVarchar> ReferencedClassDesc = new("referenced_class_desc");

        public static readonly Column<SqlNVarchar> ReferencedDatabaseName = new("referenced_database_name");

        public static readonly Column<SqlNVarchar> ReferencedEntityName = new("referenced_entity_name");

        public static readonly Column<SqlInt> ReferencedId = new("referenced_id");

        public static readonly Column<SqlInt> ReferencedMinorId = new("referenced_minor_id");

        public static readonly Column<SqlNVarchar> ReferencedSchemaName = new("referenced_schema_name");

        public static readonly Column<SqlNVarchar> ReferencedServerName = new("referenced_server_name");

        public static readonly Column<SqlTinyInt> ReferencingClass = new("referencing_class");

        public static readonly Column<SqlNVarchar> ReferencingClassDesc = new("referencing_class_desc");

        public static readonly Column<SqlInt> ReferencingId = new("referencing_id");

        public static readonly Column<SqlInt> ReferencingMinorId = new("referencing_minor_id");
    }
}
