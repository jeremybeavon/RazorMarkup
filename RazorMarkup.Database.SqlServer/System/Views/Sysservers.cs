using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysServers
    {
        public static readonly ViewName ViewName = new("sys.sysservers");

        public static readonly Column<SqlSysname> Catalog = new("catalog");

        public static readonly Column<SqlSysname> Collation = new("collation");

        public static readonly Column<SqlBit> Collationcompatible = new("collationcompatible");

        public static readonly Column<SqlInt> Connecttimeout = new("connecttimeout");

        public static readonly Column<SqlBit> Dataaccess = new("dataaccess");

        public static readonly Column<SqlNVarchar> Datasource = new("datasource");

        public static readonly Column<SqlBit> Dist = new("dist");

        public static readonly Column<SqlBit> Dpub = new("dpub");

        public static readonly Column<SqlBit> Isremote = new("isremote");

        public static readonly Column<SqlBit> Lazyschemavalidation = new("lazyschemavalidation");

        public static readonly Column<SqlNVarchar> Location = new("location");

        public static readonly Column<SqlBit> Nonsqlsub = new("nonsqlsub");

        public static readonly Column<SqlNVarchar> Providername = new("providername");

        public static readonly Column<SqlNVarchar> Providerstring = new("providerstring");

        public static readonly Column<SqlBit> Pub = new("pub");

        public static readonly Column<SqlInt> Querytimeout = new("querytimeout");

        public static readonly Column<SqlBit> Rpc = new("rpc");

        public static readonly Column<SqlBit> Rpcout = new("rpcout");

        public static readonly Column<SqlDateTime> Schemadate = new("schemadate");

        public static readonly Column<SqlSysname> Srvcollation = new("srvcollation");

        public static readonly Column<SqlSmallInt> Srvid = new("srvid");

        public static readonly Column<SqlSysname> Srvname = new("srvname");

        public static readonly Column<SqlChar> Srvnetname = new("srvnetname");

        public static readonly Column<SqlSysname> Srvproduct = new("srvproduct");

        public static readonly Column<SqlSmallInt> Srvstatus = new("srvstatus");

        public static readonly Column<SqlBit> Sub = new("sub");

        public static readonly Column<SqlBit> System = new("system");

        public static readonly Column<SqlInt> Topologyx = new("topologyx");

        public static readonly Column<SqlInt> Topologyy = new("topologyy");

        public static readonly Column<SqlBit> Useremotecollation = new("useremotecollation");
    }
}
