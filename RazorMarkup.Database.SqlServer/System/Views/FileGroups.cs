using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class FileGroups : DataSpaces
    {
        public static new readonly ViewName ViewName = new("sys.filegroups");

        public static readonly Column<SqlUniqueIdentifier> FileGroupGuid = new("filegroup_guid");

        public static readonly Column<SqlInt> LogFileGroupId = new("log_filegroup_id");

        public static readonly Column<SqlBit> IsReadOnly = new("is_read_only");
    }
}
