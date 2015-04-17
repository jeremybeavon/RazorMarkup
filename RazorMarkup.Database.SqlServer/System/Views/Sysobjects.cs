using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysObjects
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysobjects");
        
        public static readonly Column<SqlInt> BaseSchemaVer = new Column<SqlInt>("base_schema_ver");
        
        public static readonly Column<SqlSmallInt> Cache = new Column<SqlSmallInt>("cache");
        
        public static readonly Column<SqlInt> Category = new Column<SqlInt>("category");
        
        public static readonly Column<SqlDateTime> Crdate = new Column<SqlDateTime>("crdate");
        
        public static readonly Column<SqlInt> Deltrig = new Column<SqlInt>("deltrig");
        
        public static readonly Column<SqlSmallInt> Ftcatid = new Column<SqlSmallInt>("ftcatid");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlSmallInt> Indexdel = new Column<SqlSmallInt>("indexdel");
        
        public static readonly Column<SqlSmallInt> Info = new Column<SqlSmallInt>("info");
        
        public static readonly Column<SqlInt> Instrig = new Column<SqlInt>("instrig");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ParentObj = new Column<SqlInt>("parent_obj");
        
        public static readonly Column<SqlDateTime> Refdate = new Column<SqlDateTime>("refdate");
        
        public static readonly Column<SqlInt> Replinfo = new Column<SqlInt>("replinfo");
        
        public static readonly Column<SqlInt> SchemaVer = new Column<SqlInt>("schema_ver");
        
        public static readonly Column<SqlInt> Seltrig = new Column<SqlInt>("seltrig");
        
        public static readonly Column<SqlInt> StatsSchemaVer = new Column<SqlInt>("stats_schema_ver");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlSmallInt> Sysstat = new Column<SqlSmallInt>("sysstat");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
        
        public static readonly Column<SqlInt> Updtrig = new Column<SqlInt>("updtrig");
        
        public static readonly Column<SqlSmallInt> Userstat = new Column<SqlSmallInt>("userstat");
        
        public static readonly Column<SqlInt> Version = new Column<SqlInt>("version");
        
        public static readonly Column<SqlChar> Xtype = new Column<SqlChar>("xtype");
    }
}
