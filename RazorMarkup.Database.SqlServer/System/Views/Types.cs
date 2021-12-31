using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Types
    {
        public static readonly ViewName ViewName = new("sys.types");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> DefaultObjectId = new("default_object_id");

        public static readonly Column<SqlBit> IsAssemblyType = new("is_assembly_type");

        public static readonly Column<SqlBit> IsNullable = new("is_nullable");

        public static readonly Column<SqlBit> IsTableType = new("is_table_type");

        public static readonly Column<SqlBit> IsUserDefined = new("is_user_defined");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> RuleObjectId = new("rule_object_id");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlInt> SchemaId = new("schema_id");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
