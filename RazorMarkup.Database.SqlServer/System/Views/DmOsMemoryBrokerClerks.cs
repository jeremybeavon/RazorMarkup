using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryBrokerClerks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_broker_clerks");
        
        public static readonly Column<SqlNVarchar> ClerkName = new Column<SqlNVarchar>("clerk_name");
        
        public static readonly Column<SqlFloat> ExternalBenefit = new Column<SqlFloat>("external_benefit");
        
        public static readonly Column<SqlFloat> InternalBenefit = new Column<SqlFloat>("internal_benefit");
        
        public static readonly Column<SqlBigInt> InternalFreedKb = new Column<SqlBigInt>("internal_freed_kb");
        
        public static readonly Column<SqlBigInt> PeriodicFreedKb = new Column<SqlBigInt>("periodic_freed_kb");
        
        public static readonly Column<SqlBigInt> SimulatedKb = new Column<SqlBigInt>("simulated_kb");
        
        public static readonly Column<SqlFloat> SimulationBenefit = new Column<SqlFloat>("simulation_benefit");
        
        public static readonly Column<SqlBigInt> TotalKb = new Column<SqlBigInt>("total_kb");
        
        public static readonly Column<SqlFloat> ValueOfMemory = new Column<SqlFloat>("value_of_memory");
    }
}
