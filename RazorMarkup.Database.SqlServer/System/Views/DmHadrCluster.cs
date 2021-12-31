using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrCluster
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_cluster");

        public static readonly Column<SqlNVarchar> ClusterName = new("cluster_name");

        public static readonly Column<SqlTinyInt> QuorumState = new("quorum_state");

        public static readonly Column<SqlNVarchar> QuorumStateDesc = new("quorum_state_desc");

        public static readonly Column<SqlTinyInt> QuorumType = new("quorum_type");

        public static readonly Column<SqlNVarchar> QuorumTypeDesc = new("quorum_type_desc");
    }
}
