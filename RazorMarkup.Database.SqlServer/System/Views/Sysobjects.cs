using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysObjects
    {
        public static readonly ViewName ViewName = new("sys.sysobjects");

        public static readonly Column<SqlInt> BaseSchemaVer = new("base_schema_ver");

        public static readonly Column<SqlSmallInt> Cache = new("cache");

        public static readonly Column<SqlInt> Category = new("category");

        public static readonly Column<SqlDateTime> Crdate = new("crdate");

        public static readonly Column<SqlInt> Deltrig = new("deltrig");

        public static readonly Column<SqlSmallInt> Ftcatid = new("ftcatid");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlSmallInt> Indexdel = new("indexdel");

        public static readonly Column<SqlSmallInt> Info = new("info");

        public static readonly Column<SqlInt> Instrig = new("instrig");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ParentObj = new("parent_obj");

        public static readonly Column<SqlDateTime> Refdate = new("refdate");

        public static readonly Column<SqlInt> Replinfo = new("replinfo");

        public static readonly Column<SqlInt> SchemaVer = new("schema_ver");

        public static readonly Column<SqlInt> Seltrig = new("seltrig");

        public static readonly Column<SqlInt> StatsSchemaVer = new("stats_schema_ver");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlSmallInt> Sysstat = new("sysstat");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlSmallInt> Uid = new("uid");

        public static readonly Column<SqlInt> Updtrig = new("updtrig");

        public static readonly Column<SqlSmallInt> Userstat = new("userstat");

        public static readonly Column<SqlInt> Version = new("version");

        public static readonly Column<SqlChar> Xtype = new("xtype");
    }
}
