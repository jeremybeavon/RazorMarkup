using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLockInfo
    {
        public static readonly ViewName ViewName = new("sys.syslockinfo");

        public static readonly Column<SqlSmallInt> ReqCryrefcnt = new("req_cryrefcnt");

        public static readonly Column<SqlInt> ReqEcid = new("req_ecid");

        public static readonly Column<SqlInt> ReqLifetime = new("req_lifetime");

        public static readonly Column<SqlTinyInt> ReqMode = new("req_mode");

        public static readonly Column<SqlSmallInt> ReqOwnertype = new("req_ownertype");

        public static readonly Column<SqlSmallInt> ReqRefcnt = new("req_refcnt");

        public static readonly Column<SqlInt> ReqSpid = new("req_spid");

        public static readonly Column<SqlTinyInt> ReqStatus = new("req_status");

        public static readonly Column<SqlBigInt> ReqTransactionid = new("req_transactionID");

        public static readonly Column<SqlUniqueIdentifier> ReqTransactionuow = new("req_transactionUOW");

        public static readonly Column<SqlBinary> RscBin = new("rsc_bin");

        public static readonly Column<SqlSmallInt> RscDbid = new("rsc_dbid");

        public static readonly Column<SqlTinyInt> RscFlag = new("rsc_flag");

        public static readonly Column<SqlSmallInt> RscIndid = new("rsc_indid");

        public static readonly Column<SqlInt> RscObjid = new("rsc_objid");

        public static readonly Column<SqlNChar> RscText = new("rsc_text");

        public static readonly Column<SqlTinyInt> RscType = new("rsc_type");

        public static readonly Column<SqlBinary> RscValblk = new("rsc_valblk");
    }
}
