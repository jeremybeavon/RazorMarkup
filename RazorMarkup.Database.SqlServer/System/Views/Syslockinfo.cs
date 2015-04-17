using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLockInfo
    {
        public static readonly ViewName ViewName = new ViewName("sys.syslockinfo");
        
        public static readonly Column<SqlSmallInt> ReqCryrefcnt = new Column<SqlSmallInt>("req_cryrefcnt");
        
        public static readonly Column<SqlInt> ReqEcid = new Column<SqlInt>("req_ecid");
        
        public static readonly Column<SqlInt> ReqLifetime = new Column<SqlInt>("req_lifetime");
        
        public static readonly Column<SqlTinyInt> ReqMode = new Column<SqlTinyInt>("req_mode");
        
        public static readonly Column<SqlSmallInt> ReqOwnertype = new Column<SqlSmallInt>("req_ownertype");
        
        public static readonly Column<SqlSmallInt> ReqRefcnt = new Column<SqlSmallInt>("req_refcnt");
        
        public static readonly Column<SqlInt> ReqSpid = new Column<SqlInt>("req_spid");
        
        public static readonly Column<SqlTinyInt> ReqStatus = new Column<SqlTinyInt>("req_status");
        
        public static readonly Column<SqlBigInt> ReqTransactionid = new Column<SqlBigInt>("req_transactionID");
        
        public static readonly Column<SqlUniqueIdentifier> ReqTransactionuow = new Column<SqlUniqueIdentifier>("req_transactionUOW");
        
        public static readonly Column<SqlBinary> RscBin = new Column<SqlBinary>("rsc_bin");
        
        public static readonly Column<SqlSmallInt> RscDbid = new Column<SqlSmallInt>("rsc_dbid");
        
        public static readonly Column<SqlTinyInt> RscFlag = new Column<SqlTinyInt>("rsc_flag");
        
        public static readonly Column<SqlSmallInt> RscIndid = new Column<SqlSmallInt>("rsc_indid");
        
        public static readonly Column<SqlInt> RscObjid = new Column<SqlInt>("rsc_objid");
        
        public static readonly Column<SqlNChar> RscText = new Column<SqlNChar>("rsc_text");
        
        public static readonly Column<SqlTinyInt> RscType = new Column<SqlTinyInt>("rsc_type");
        
        public static readonly Column<SqlBinary> RscValblk = new Column<SqlBinary>("rsc_valblk");
    }
}
