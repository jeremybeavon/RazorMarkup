using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscacheobjects
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscacheobjects");
        
        public static readonly Column<SqlBigInt> Avgexectime = new Column<SqlBigInt>("avgexectime");
        
        public static readonly Column<SqlInt> Bucketid = new Column<SqlInt>("bucketid");
        
        public static readonly Column<SqlNVarchar> Cacheobjtype = new Column<SqlNVarchar>("cacheobjtype");
        
        public static readonly Column<SqlSmallInt> Dateformat = new Column<SqlSmallInt>("dateformat");
        
        public static readonly Column<SqlSmallInt> Dbid = new Column<SqlSmallInt>("dbid");
        
        public static readonly Column<SqlSmallInt> Dbidexec = new Column<SqlSmallInt>("dbidexec");
        
        public static readonly Column<SqlSmallInt> Langid = new Column<SqlSmallInt>("langid");
        
        public static readonly Column<SqlBigInt> Lastreads = new Column<SqlBigInt>("lastreads");
        
        public static readonly Column<SqlBigInt> Lasttime = new Column<SqlBigInt>("lasttime");
        
        public static readonly Column<SqlBigInt> Lastwrites = new Column<SqlBigInt>("lastwrites");
        
        public static readonly Column<SqlBigInt> Maxexectime = new Column<SqlBigInt>("maxexectime");
        
        public static readonly Column<SqlInt> Objid = new Column<SqlInt>("objid");
        
        public static readonly Column<SqlNVarchar> Objtype = new Column<SqlNVarchar>("objtype");
        
        public static readonly Column<SqlInt> Pagesused = new Column<SqlInt>("pagesused");
        
        public static readonly Column<SqlInt> Refcounts = new Column<SqlInt>("refcounts");
        
        public static readonly Column<SqlInt> Setopts = new Column<SqlInt>("setopts");
        
        public static readonly Column<SqlNVarchar> Sql = new Column<SqlNVarchar>("sql");
        
        public static readonly Column<SqlInt> Sqlbytes = new Column<SqlInt>("sqlbytes");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
        
        public static readonly Column<SqlInt> Usecounts = new Column<SqlInt>("usecounts");
    }
}
