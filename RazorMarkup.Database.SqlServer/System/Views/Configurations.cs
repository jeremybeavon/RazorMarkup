using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Configurations
    {
        public static readonly ViewName ViewName = new ViewName("sys.configurations");
        
        public static readonly Column<SqlInt> ConfigurationId = new Column<SqlInt>("configuration_id");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlBit> IsAdvanced = new Column<SqlBit>("is_advanced");
        
        public static readonly Column<SqlBit> IsDynamic = new Column<SqlBit>("is_dynamic");
        
        public static readonly Column<SqlVariant> Maximum = new Column<SqlVariant>("maximum");
        
        public static readonly Column<SqlVariant> Minimum = new Column<SqlVariant>("minimum");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlVariant> Value = new Column<SqlVariant>("value");
        
        public static readonly Column<SqlVariant> ValueInUse = new Column<SqlVariant>("value_in_use");
    }
}
