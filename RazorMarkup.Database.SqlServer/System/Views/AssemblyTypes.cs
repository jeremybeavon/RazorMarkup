using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AssemblyTypes
    {
        public static readonly ViewName ViewName = new("sys.assembly_types");

        public static readonly Column<SqlSysname> AssemblyClass = new("assembly_class");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlNVarchar> AssemblyQualifiedName = new("assembly_qualified_name");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> DefaultObjectId = new("default_object_id");

        public static readonly Column<SqlBit> IsAssemblyType = new("is_assembly_type");

        public static readonly Column<SqlBit> IsBinaryOrdered = new("is_binary_ordered");

        public static readonly Column<SqlBit> IsFixedLength = new("is_fixed_length");

        public static readonly Column<SqlBit> IsNullable = new("is_nullable");

        public static readonly Column<SqlBit> IsTableType = new("is_table_type");

        public static readonly Column<SqlBit> IsUserDefined = new("is_user_defined");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlNVarchar> ProgId = new("prog_id");

        public static readonly Column<SqlInt> RuleObjectId = new("rule_object_id");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlInt> SchemaId = new("schema_id");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
