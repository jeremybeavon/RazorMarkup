using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrAppdomains
    {
        public static readonly ViewName ViewName = new("sys.dm_clr_appdomains");

        public static readonly Column<SqlVarbinary> AppdomainAddress = new("appdomain_address");

        public static readonly Column<SqlInt> AppdomainId = new("appdomain_id");

        public static readonly Column<SqlNVarchar> AppdomainName = new("appdomain_name");

        public static readonly Column<SqlInt> CompatibilityLevel = new("compatibility_level");

        public static readonly Column<SqlInt> Cost = new("cost");

        public static readonly Column<SqlDateTime> CreationTime = new("creation_time");

        public static readonly Column<SqlInt> DbId = new("db_id");

        public static readonly Column<SqlNVarchar> State = new("state");

        public static readonly Column<SqlInt> StrongRefcount = new("strong_refcount");

        public static readonly Column<SqlBigInt> SurvivedMemoryKb = new("survived_memory_kb");

        public static readonly Column<SqlBigInt> TotalAllocatedMemoryKb = new("total_allocated_memory_kb");

        public static readonly Column<SqlBigInt> TotalProcessorTimeMs = new("total_processor_time_ms");

        public static readonly Column<SqlInt> UserId = new("user_id");

        public static readonly Column<SqlInt> Value = new("value");

        public static readonly Column<SqlInt> WeakRefcount = new("weak_refcount");
    }
}
