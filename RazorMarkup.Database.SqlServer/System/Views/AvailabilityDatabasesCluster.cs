using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityDatabasesCluster
    {
        public static readonly ViewName ViewName = new("sys.availability_databases_cluster");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new("group_database_id");

        public static readonly Column<SqlSysname> DatabaseName = new("database_name");

        private AvailabilityDatabasesCluster()
        {
        }
    }
}
