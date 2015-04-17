using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlExpressionDependencies
    {
        public static readonly ViewName ViewName = new ViewName("sys.sql_expression_dependencies");
        
        public static readonly Column<SqlBit> IsAmbiguous = new Column<SqlBit>("is_ambiguous");
        
        public static readonly Column<SqlBit> IsCallerDependent = new Column<SqlBit>("is_caller_dependent");
        
        public static readonly Column<SqlBit> IsSchemaBoundReference = new Column<SqlBit>("is_schema_bound_reference");
        
        public static readonly Column<SqlTinyInt> ReferencedClass = new Column<SqlTinyInt>("referenced_class");
        
        public static readonly Column<SqlNVarchar> ReferencedClassDesc = new Column<SqlNVarchar>("referenced_class_desc");
        
        public static readonly Column<SqlNVarchar> ReferencedDatabaseName = new Column<SqlNVarchar>("referenced_database_name");
        
        public static readonly Column<SqlNVarchar> ReferencedEntityName = new Column<SqlNVarchar>("referenced_entity_name");
        
        public static readonly Column<SqlInt> ReferencedId = new Column<SqlInt>("referenced_id");
        
        public static readonly Column<SqlInt> ReferencedMinorId = new Column<SqlInt>("referenced_minor_id");
        
        public static readonly Column<SqlNVarchar> ReferencedSchemaName = new Column<SqlNVarchar>("referenced_schema_name");
        
        public static readonly Column<SqlNVarchar> ReferencedServerName = new Column<SqlNVarchar>("referenced_server_name");
        
        public static readonly Column<SqlTinyInt> ReferencingClass = new Column<SqlTinyInt>("referencing_class");
        
        public static readonly Column<SqlNVarchar> ReferencingClassDesc = new Column<SqlNVarchar>("referencing_class_desc");
        
        public static readonly Column<SqlInt> ReferencingId = new Column<SqlInt>("referencing_id");
        
        public static readonly Column<SqlInt> ReferencingMinorId = new Column<SqlInt>("referencing_minor_id");
    }
}
