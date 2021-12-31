using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextStoplists
    {
        public static readonly ViewName ViewName = new("sys.fulltext_stoplists");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> StoplistId = new("stoplist_id");
    }
}
