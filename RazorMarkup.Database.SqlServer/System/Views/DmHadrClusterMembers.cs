using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrClusterMembers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_cluster_members");
        
        public static readonly Column<SqlNVarchar> MemberName = new Column<SqlNVarchar>("member_name");
        
        public static readonly Column<SqlTinyInt> MemberState = new Column<SqlTinyInt>("member_state");
        
        public static readonly Column<SqlNVarchar> MemberStateDesc = new Column<SqlNVarchar>("member_state_desc");
        
        public static readonly Column<SqlTinyInt> MemberType = new Column<SqlTinyInt>("member_type");
        
        public static readonly Column<SqlNVarchar> MemberTypeDesc = new Column<SqlNVarchar>("member_type_desc");
        
        public static readonly Column<SqlInt> NumberOfQuorumVotes = new Column<SqlInt>("number_of_quorum_votes");
    }
}
