using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorConfiguration
    {
        public static readonly ViewName ViewName = new("sys.dm_resource_governor_configuration");

        public static readonly Column<SqlInt> ClassifierFunctionId = new("classifier_function_id");

        public static readonly Column<SqlTinyInt> IsReconfigurationPending = new("is_reconfiguration_pending");
    }
}
