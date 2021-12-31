using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class MasterFiles
    {
        public static readonly ViewName ViewName = new("sys.master_files");

        public static readonly Column<SqlNumeric> BackupLsn = new("backup_lsn");

        public static readonly Column<SqlNumeric> CreateLsn = new("create_lsn");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlUniqueIdentifier> DifferentialBaseGuid = new("differential_base_guid");

        public static readonly Column<SqlNumeric> DifferentialBaseLsn = new("differential_base_lsn");

        public static readonly Column<SqlDateTime> DifferentialBaseTime = new("differential_base_time");

        public static readonly Column<SqlNumeric> DropLsn = new("drop_lsn");

        public static readonly Column<SqlUniqueIdentifier> FileGuid = new("file_guid");

        public static readonly Column<SqlInt> FileId = new("file_id");

        public static readonly Column<SqlInt> Growth = new("growth");

        public static readonly Column<SqlBit> IsMediaReadOnly = new("is_media_read_only");

        public static readonly Column<SqlBit> IsNameReserved = new("is_name_reserved");

        public static readonly Column<SqlBit> IsPercentGrowth = new("is_percent_growth");

        public static readonly Column<SqlBit> IsReadOnly = new("is_read_only");

        public static readonly Column<SqlBit> IsSparse = new("is_sparse");

        public static readonly Column<SqlInt> MaxSize = new("max_size");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> PhysicalName = new("physical_name");

        public static readonly Column<SqlNumeric> ReadOnlyLsn = new("read_only_lsn");

        public static readonly Column<SqlNumeric> ReadWriteLsn = new("read_write_lsn");

        public static readonly Column<SqlUniqueIdentifier> RedoStartForkGuid = new("redo_start_fork_guid");

        public static readonly Column<SqlNumeric> RedoStartLsn = new("redo_start_lsn");

        public static readonly Column<SqlUniqueIdentifier> RedoTargetForkGuid = new("redo_target_fork_guid");

        public static readonly Column<SqlNumeric> RedoTargetLsn = new("redo_target_lsn");

        public static readonly Column<SqlInt> Size = new("size");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
