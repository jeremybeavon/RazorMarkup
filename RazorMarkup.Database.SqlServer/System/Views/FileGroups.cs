using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class FileGroups : DataSpaces
    {
        public new static readonly ViewName ViewName = new ViewName("sys.filegroups");

        public static readonly Column<SqlUniqueIdentifier> FileGroupGuid = new Column<SqlUniqueIdentifier>("filegroup_guid");

        public static readonly Column<SqlInt> LogFileGroupId = new Column<SqlInt>("log_filegroup_id");

        public static readonly Column<SqlBit> IsReadOnly = new Column<SqlBit>("is_read_only");
    }
}
