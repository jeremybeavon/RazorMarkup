using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class DatabasesOutput
    {
        public static readonly Column<SqlSysname> DatabaseName = new("DATABASE_NAME");

        public static readonly Column<SqlSysname> DatabaseSizeInKilobytes = new("DATABASE_SIZE");

        public static readonly Column<SqlVarchar> Remarks = new("REMARKS");
    }
}
