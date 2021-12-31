using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplTraninfo
    {
        public static readonly ViewName ViewName = new("sys.dm_repl_traninfo");

        public static readonly Column<SqlVarbinary> ArtcacheTableAddress = new("artcache_table_address");

        public static readonly Column<SqlNVarchar> BeginLsn = new("begin_lsn");

        public static readonly Column<SqlDateTime> BeginTime = new("begin_time");

        public static readonly Column<SqlNVarchar> BeginUpdateLsn = new("begin_update_lsn");

        public static readonly Column<SqlInt> CmdsInTran = new("cmds_in_tran");

        public static readonly Column<SqlNVarchar> CommitLsn = new("commit_lsn");

        public static readonly Column<SqlDateTime> CommitTime = new("commit_time");

        public static readonly Column<SqlVarbinary> CompRangeAddress = new("comp_range_address");

        public static readonly Column<SqlNVarchar> Database = new("database");

        public static readonly Column<SqlInt> DbLenInBytes = new("db_len_in_bytes");

        public static readonly Column<SqlInt> DbVer = new("db_ver");

        public static readonly Column<SqlSmallInt> Dbid = new("dbid");

        public static readonly Column<SqlNVarchar> DeleteLsn = new("delete_lsn");

        public static readonly Column<SqlInt> ErrorCount = new("error_count");

        public static readonly Column<SqlTinyInt> Fcompensated = new("fcompensated");

        public static readonly Column<SqlTinyInt> Fcomplete = new("fcomplete");

        public static readonly Column<SqlTinyInt> Fp2pPubExists = new("fp2p_pub_exists");

        public static readonly Column<SqlTinyInt> Fprocessingtext = new("fprocessingtext");

        public static readonly Column<SqlVarbinary> FsinfoAddress = new("fsinfo_address");

        public static readonly Column<SqlTinyInt> IsBoundedupdateSingleton = new("is_boundedupdate_singleton");

        public static readonly Column<SqlTinyInt> IsKnownCdcTran = new("is_known_cdc_tran");

        public static readonly Column<SqlNVarchar> LastEndLsn = new("last_end_lsn");

        public static readonly Column<SqlInt> MaxCmdsInTran = new("max_cmds_in_tran");

        public static readonly Column<SqlNVarchar> OrigDb = new("orig_db");

        public static readonly Column<SqlInt> OrigDbLenInBytes = new("orig_db_len_in_bytes");

        public static readonly Column<SqlNVarchar> Originator = new("originator");

        public static readonly Column<SqlInt> OriginatorLenInBytes = new("originator_len_in_bytes");

        public static readonly Column<SqlInt> Rows = new("rows");

        public static readonly Column<SqlNVarchar> Server = new("server");

        public static readonly Column<SqlInt> ServerLenInBytes = new("server_len_in_bytes");

        public static readonly Column<SqlInt> SessionId = new("session_id");

        public static readonly Column<SqlNVarchar> SessionPhase = new("session_phase");

        public static readonly Column<SqlVarbinary> TextinfoAddress = new("textinfo_address");

        public static readonly Column<SqlNVarchar> Xdesid = new("xdesid");
    }
}
