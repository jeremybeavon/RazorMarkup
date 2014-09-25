using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityDatabasesCluster
    {
        public static readonly ViewName ViewName = new ViewName("sys.availability_databases_cluster");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");

        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new Column<SqlUniqueIdentifier>("group_database_id");

        public static readonly Column<SqlSysname> DatabaseName = new Column<SqlSysname>("database_name");

        private AvailabilityDatabasesCluster()
        {
        }
    }
}
