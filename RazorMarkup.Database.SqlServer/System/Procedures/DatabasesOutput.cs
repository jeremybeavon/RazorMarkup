using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class DatabasesOutput
    {
        public static readonly Column<SqlSysname> DatabaseName = new Column<SqlSysname>("DATABASE_NAME");

        public static readonly Column<SqlSysname> DatabaseSizeInKilobytes = new Column<SqlSysname>("DATABASE_SIZE");

        public static readonly Column<SqlVarchar> Remarks = new Column<SqlVarchar>("REMARKS");
    }
}
