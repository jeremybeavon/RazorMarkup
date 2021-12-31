using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrClusterMembers
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_cluster_members");

        public static readonly Column<SqlNVarchar> MemberName = new("member_name");

        public static readonly Column<SqlTinyInt> MemberState = new("member_state");

        public static readonly Column<SqlNVarchar> MemberStateDesc = new("member_state_desc");

        public static readonly Column<SqlTinyInt> MemberType = new("member_type");

        public static readonly Column<SqlNVarchar> MemberTypeDesc = new("member_type_desc");

        public static readonly Column<SqlInt> NumberOfQuorumVotes = new("number_of_quorum_votes");
    }
}
