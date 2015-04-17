using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrCluster
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_cluster");
        
        public static readonly Column<SqlNVarchar> ClusterName = new Column<SqlNVarchar>("cluster_name");
        
        public static readonly Column<SqlTinyInt> QuorumState = new Column<SqlTinyInt>("quorum_state");
        
        public static readonly Column<SqlNVarchar> QuorumStateDesc = new Column<SqlNVarchar>("quorum_state_desc");
        
        public static readonly Column<SqlTinyInt> QuorumType = new Column<SqlTinyInt>("quorum_type");
        
        public static readonly Column<SqlNVarchar> QuorumTypeDesc = new Column<SqlNVarchar>("quorum_type_desc");
    }
}
