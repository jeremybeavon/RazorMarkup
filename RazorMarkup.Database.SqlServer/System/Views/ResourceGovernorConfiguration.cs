using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorConfiguration
    {
        public static readonly ViewName ViewName = new ViewName("sys.resource_governor_configuration");
        
        public static readonly Column<SqlInt> ClassifierFunctionId = new Column<SqlInt>("classifier_function_id");
        
        public static readonly Column<SqlBit> IsEnabled = new Column<SqlBit>("is_enabled");
    }
}
