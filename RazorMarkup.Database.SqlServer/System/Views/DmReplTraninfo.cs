using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplTraninfo
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_repl_traninfo");
        
        public static readonly Column<SqlVarbinary> ArtcacheTableAddress = new Column<SqlVarbinary>("artcache_table_address");
        
        public static readonly Column<SqlNVarchar> BeginLsn = new Column<SqlNVarchar>("begin_lsn");
        
        public static readonly Column<SqlDateTime> BeginTime = new Column<SqlDateTime>("begin_time");
        
        public static readonly Column<SqlNVarchar> BeginUpdateLsn = new Column<SqlNVarchar>("begin_update_lsn");
        
        public static readonly Column<SqlInt> CmdsInTran = new Column<SqlInt>("cmds_in_tran");
        
        public static readonly Column<SqlNVarchar> CommitLsn = new Column<SqlNVarchar>("commit_lsn");
        
        public static readonly Column<SqlDateTime> CommitTime = new Column<SqlDateTime>("commit_time");
        
        public static readonly Column<SqlVarbinary> CompRangeAddress = new Column<SqlVarbinary>("comp_range_address");
        
        public static readonly Column<SqlNVarchar> Database = new Column<SqlNVarchar>("database");
        
        public static readonly Column<SqlInt> DbLenInBytes = new Column<SqlInt>("db_len_in_bytes");
        
        public static readonly Column<SqlInt> DbVer = new Column<SqlInt>("db_ver");
        
        public static readonly Column<SqlSmallInt> Dbid = new Column<SqlSmallInt>("dbid");
        
        public static readonly Column<SqlNVarchar> DeleteLsn = new Column<SqlNVarchar>("delete_lsn");
        
        public static readonly Column<SqlInt> ErrorCount = new Column<SqlInt>("error_count");
        
        public static readonly Column<SqlTinyInt> Fcompensated = new Column<SqlTinyInt>("fcompensated");
        
        public static readonly Column<SqlTinyInt> Fcomplete = new Column<SqlTinyInt>("fcomplete");
        
        public static readonly Column<SqlTinyInt> Fp2pPubExists = new Column<SqlTinyInt>("fp2p_pub_exists");
        
        public static readonly Column<SqlTinyInt> Fprocessingtext = new Column<SqlTinyInt>("fprocessingtext");
        
        public static readonly Column<SqlVarbinary> FsinfoAddress = new Column<SqlVarbinary>("fsinfo_address");
        
        public static readonly Column<SqlTinyInt> IsBoundedupdateSingleton = new Column<SqlTinyInt>("is_boundedupdate_singleton");
        
        public static readonly Column<SqlTinyInt> IsKnownCdcTran = new Column<SqlTinyInt>("is_known_cdc_tran");
        
        public static readonly Column<SqlNVarchar> LastEndLsn = new Column<SqlNVarchar>("last_end_lsn");
        
        public static readonly Column<SqlInt> MaxCmdsInTran = new Column<SqlInt>("max_cmds_in_tran");
        
        public static readonly Column<SqlNVarchar> OrigDb = new Column<SqlNVarchar>("orig_db");
        
        public static readonly Column<SqlInt> OrigDbLenInBytes = new Column<SqlInt>("orig_db_len_in_bytes");
        
        public static readonly Column<SqlNVarchar> Originator = new Column<SqlNVarchar>("originator");
        
        public static readonly Column<SqlInt> OriginatorLenInBytes = new Column<SqlInt>("originator_len_in_bytes");
        
        public static readonly Column<SqlInt> Rows = new Column<SqlInt>("rows");
        
        public static readonly Column<SqlNVarchar> Server = new Column<SqlNVarchar>("server");
        
        public static readonly Column<SqlInt> ServerLenInBytes = new Column<SqlInt>("server_len_in_bytes");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
        
        public static readonly Column<SqlNVarchar> SessionPhase = new Column<SqlNVarchar>("session_phase");
        
        public static readonly Column<SqlVarbinary> TextinfoAddress = new Column<SqlVarbinary>("textinfo_address");
        
        public static readonly Column<SqlNVarchar> Xdesid = new Column<SqlNVarchar>("xdesid");
    }
}
