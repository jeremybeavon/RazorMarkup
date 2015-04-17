using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysservers
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysservers");
        
        public static readonly Column<SqlSysname> Catalog = new Column<SqlSysname>("catalog");
        
        public static readonly Column<SqlSysname> Collation = new Column<SqlSysname>("collation");
        
        public static readonly Column<SqlBit> Collationcompatible = new Column<SqlBit>("collationcompatible");
        
        public static readonly Column<SqlInt> Connecttimeout = new Column<SqlInt>("connecttimeout");
        
        public static readonly Column<SqlBit> Dataaccess = new Column<SqlBit>("dataaccess");
        
        public static readonly Column<SqlNVarchar> Datasource = new Column<SqlNVarchar>("datasource");
        
        public static readonly Column<SqlBit> Dist = new Column<SqlBit>("dist");
        
        public static readonly Column<SqlBit> Dpub = new Column<SqlBit>("dpub");
        
        public static readonly Column<SqlBit> Isremote = new Column<SqlBit>("isremote");
        
        public static readonly Column<SqlBit> Lazyschemavalidation = new Column<SqlBit>("lazyschemavalidation");
        
        public static readonly Column<SqlNVarchar> Location = new Column<SqlNVarchar>("location");
        
        public static readonly Column<SqlBit> Nonsqlsub = new Column<SqlBit>("nonsqlsub");
        
        public static readonly Column<SqlNVarchar> Providername = new Column<SqlNVarchar>("providername");
        
        public static readonly Column<SqlNVarchar> Providerstring = new Column<SqlNVarchar>("providerstring");
        
        public static readonly Column<SqlBit> Pub = new Column<SqlBit>("pub");
        
        public static readonly Column<SqlInt> Querytimeout = new Column<SqlInt>("querytimeout");
        
        public static readonly Column<SqlBit> Rpc = new Column<SqlBit>("rpc");
        
        public static readonly Column<SqlBit> Rpcout = new Column<SqlBit>("rpcout");
        
        public static readonly Column<SqlDateTime> Schemadate = new Column<SqlDateTime>("schemadate");
        
        public static readonly Column<SqlSysname> Srvcollation = new Column<SqlSysname>("srvcollation");
        
        public static readonly Column<SqlSmallInt> Srvid = new Column<SqlSmallInt>("srvid");
        
        public static readonly Column<SqlSysname> Srvname = new Column<SqlSysname>("srvname");
        
        public static readonly Column<SqlChar> Srvnetname = new Column<SqlChar>("srvnetname");
        
        public static readonly Column<SqlSysname> Srvproduct = new Column<SqlSysname>("srvproduct");
        
        public static readonly Column<SqlSmallInt> Srvstatus = new Column<SqlSmallInt>("srvstatus");
        
        public static readonly Column<SqlBit> Sub = new Column<SqlBit>("sub");
        
        public static readonly Column<SqlBit> System = new Column<SqlBit>("system");
        
        public static readonly Column<SqlInt> Topologyx = new Column<SqlInt>("topologyx");
        
        public static readonly Column<SqlInt> Topologyy = new Column<SqlInt>("topologyy");
        
        public static readonly Column<SqlBit> Useremotecollation = new Column<SqlBit>("useremotecollation");
    }
}
