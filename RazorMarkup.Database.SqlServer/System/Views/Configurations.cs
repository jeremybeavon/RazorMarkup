using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Configurations
    {
        public static readonly ViewName ViewName = new("sys.configurations");

        public static readonly Column<SqlInt> ConfigurationId = new("configuration_id");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlBit> IsAdvanced = new("is_advanced");

        public static readonly Column<SqlBit> IsDynamic = new("is_dynamic");

        public static readonly Column<SqlVariant> Maximum = new("maximum");

        public static readonly Column<SqlVariant> Minimum = new("minimum");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlVariant> Value = new("value");

        public static readonly Column<SqlVariant> ValueInUse = new("value_in_use");
    }
}
