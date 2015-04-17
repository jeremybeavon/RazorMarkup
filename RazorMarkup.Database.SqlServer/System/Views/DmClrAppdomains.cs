using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrAppdomains
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_clr_appdomains");
        
        public static readonly Column<SqlVarbinary> AppdomainAddress = new Column<SqlVarbinary>("appdomain_address");
        
        public static readonly Column<SqlInt> AppdomainId = new Column<SqlInt>("appdomain_id");
        
        public static readonly Column<SqlNVarchar> AppdomainName = new Column<SqlNVarchar>("appdomain_name");
        
        public static readonly Column<SqlInt> CompatibilityLevel = new Column<SqlInt>("compatibility_level");
        
        public static readonly Column<SqlInt> Cost = new Column<SqlInt>("cost");
        
        public static readonly Column<SqlDateTime> CreationTime = new Column<SqlDateTime>("creation_time");
        
        public static readonly Column<SqlInt> DbId = new Column<SqlInt>("db_id");
        
        public static readonly Column<SqlNVarchar> State = new Column<SqlNVarchar>("state");
        
        public static readonly Column<SqlInt> StrongRefcount = new Column<SqlInt>("strong_refcount");
        
        public static readonly Column<SqlBigInt> SurvivedMemoryKb = new Column<SqlBigInt>("survived_memory_kb");
        
        public static readonly Column<SqlBigInt> TotalAllocatedMemoryKb = new Column<SqlBigInt>("total_allocated_memory_kb");
        
        public static readonly Column<SqlBigInt> TotalProcessorTimeMs = new Column<SqlBigInt>("total_processor_time_ms");
        
        public static readonly Column<SqlInt> UserId = new Column<SqlInt>("user_id");
        
        public static readonly Column<SqlInt> Value = new Column<SqlInt>("value");
        
        public static readonly Column<SqlInt> WeakRefcount = new Column<SqlInt>("weak_refcount");
    }
}
