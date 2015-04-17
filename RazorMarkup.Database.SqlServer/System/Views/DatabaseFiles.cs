using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseFiles
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_files");
        
        public static readonly Column<SqlNumeric> BackupLsn = new Column<SqlNumeric>("backup_lsn");
        
        public static readonly Column<SqlNumeric> CreateLsn = new Column<SqlNumeric>("create_lsn");
        
        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
        
        public static readonly Column<SqlUniqueIdentifier> DifferentialBaseGuid = new Column<SqlUniqueIdentifier>("differential_base_guid");
        
        public static readonly Column<SqlNumeric> DifferentialBaseLsn = new Column<SqlNumeric>("differential_base_lsn");
        
        public static readonly Column<SqlDateTime> DifferentialBaseTime = new Column<SqlDateTime>("differential_base_time");
        
        public static readonly Column<SqlNumeric> DropLsn = new Column<SqlNumeric>("drop_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> FileGuid = new Column<SqlUniqueIdentifier>("file_guid");
        
        public static readonly Column<SqlInt> FileId = new Column<SqlInt>("file_id");
        
        public static readonly Column<SqlInt> Growth = new Column<SqlInt>("growth");
        
        public static readonly Column<SqlBit> IsMediaReadOnly = new Column<SqlBit>("is_media_read_only");
        
        public static readonly Column<SqlBit> IsNameReserved = new Column<SqlBit>("is_name_reserved");
        
        public static readonly Column<SqlBit> IsPercentGrowth = new Column<SqlBit>("is_percent_growth");
        
        public static readonly Column<SqlBit> IsReadOnly = new Column<SqlBit>("is_read_only");
        
        public static readonly Column<SqlBit> IsSparse = new Column<SqlBit>("is_sparse");
        
        public static readonly Column<SqlInt> MaxSize = new Column<SqlInt>("max_size");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> PhysicalName = new Column<SqlNVarchar>("physical_name");
        
        public static readonly Column<SqlNumeric> ReadOnlyLsn = new Column<SqlNumeric>("read_only_lsn");
        
        public static readonly Column<SqlNumeric> ReadWriteLsn = new Column<SqlNumeric>("read_write_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> RedoStartForkGuid = new Column<SqlUniqueIdentifier>("redo_start_fork_guid");
        
        public static readonly Column<SqlNumeric> RedoStartLsn = new Column<SqlNumeric>("redo_start_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> RedoTargetForkGuid = new Column<SqlUniqueIdentifier>("redo_target_fork_guid");
        
        public static readonly Column<SqlNumeric> RedoTargetLsn = new Column<SqlNumeric>("redo_target_lsn");
        
        public static readonly Column<SqlInt> Size = new Column<SqlInt>("size");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
