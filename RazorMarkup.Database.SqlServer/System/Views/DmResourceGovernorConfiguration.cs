using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorConfiguration
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_resource_governor_configuration");
        
        public static readonly Column<SqlInt> ClassifierFunctionId = new Column<SqlInt>("classifier_function_id");
        
        public static readonly Column<SqlTinyInt> IsReconfigurationPending = new Column<SqlTinyInt>("is_reconfiguration_pending");
    }
}
