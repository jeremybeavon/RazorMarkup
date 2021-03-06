using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AssemblyTypes
    {
        public static readonly ViewName ViewName = new ViewName("sys.assembly_types");
        
        public static readonly Column<SqlSysname> AssemblyClass = new Column<SqlSysname>("assembly_class");
        
        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");
        
        public static readonly Column<SqlNVarchar> AssemblyQualifiedName = new Column<SqlNVarchar>("assembly_qualified_name");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlInt> DefaultObjectId = new Column<SqlInt>("default_object_id");
        
        public static readonly Column<SqlBit> IsAssemblyType = new Column<SqlBit>("is_assembly_type");
        
        public static readonly Column<SqlBit> IsBinaryOrdered = new Column<SqlBit>("is_binary_ordered");
        
        public static readonly Column<SqlBit> IsFixedLength = new Column<SqlBit>("is_fixed_length");
        
        public static readonly Column<SqlBit> IsNullable = new Column<SqlBit>("is_nullable");
        
        public static readonly Column<SqlBit> IsTableType = new Column<SqlBit>("is_table_type");
        
        public static readonly Column<SqlBit> IsUserDefined = new Column<SqlBit>("is_user_defined");
        
        public static readonly Column<SqlSmallInt> MaxLength = new Column<SqlSmallInt>("max_length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlTinyInt> Precision = new Column<SqlTinyInt>("precision");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlNVarchar> ProgId = new Column<SqlNVarchar>("prog_id");
        
        public static readonly Column<SqlInt> RuleObjectId = new Column<SqlInt>("rule_object_id");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlTinyInt> SystemTypeId = new Column<SqlTinyInt>("system_type_id");
        
        public static readonly Column<SqlInt> UserTypeId = new Column<SqlInt>("user_type_id");
    }
}
