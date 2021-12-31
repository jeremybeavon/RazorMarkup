using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCacheObjects
    {
        public static readonly ViewName ViewName = new("sys.syscacheobjects");

        public static readonly Column<SqlBigInt> Avgexectime = new("avgexectime");

        public static readonly Column<SqlInt> Bucketid = new("bucketid");

        public static readonly Column<SqlNVarchar> Cacheobjtype = new("cacheobjtype");

        public static readonly Column<SqlSmallInt> Dateformat = new("dateformat");

        public static readonly Column<SqlSmallInt> Dbid = new("dbid");

        public static readonly Column<SqlSmallInt> Dbidexec = new("dbidexec");

        public static readonly Column<SqlSmallInt> Langid = new("langid");

        public static readonly Column<SqlBigInt> Lastreads = new("lastreads");

        public static readonly Column<SqlBigInt> Lasttime = new("lasttime");

        public static readonly Column<SqlBigInt> Lastwrites = new("lastwrites");

        public static readonly Column<SqlBigInt> Maxexectime = new("maxexectime");

        public static readonly Column<SqlInt> Objid = new("objid");

        public static readonly Column<SqlNVarchar> Objtype = new("objtype");

        public static readonly Column<SqlInt> Pagesused = new("pagesused");

        public static readonly Column<SqlInt> Refcounts = new("refcounts");

        public static readonly Column<SqlInt> Setopts = new("setopts");

        public static readonly Column<SqlNVarchar> Sql = new("sql");

        public static readonly Column<SqlInt> Sqlbytes = new("sqlbytes");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlSmallInt> Uid = new("uid");

        public static readonly Column<SqlInt> Usecounts = new("usecounts");
    }
}
