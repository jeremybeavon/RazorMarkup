using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryBrokerClerks
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_broker_clerks");

        public static readonly Column<SqlNVarchar> ClerkName = new("clerk_name");

        public static readonly Column<SqlFloat> ExternalBenefit = new("external_benefit");

        public static readonly Column<SqlFloat> InternalBenefit = new("internal_benefit");

        public static readonly Column<SqlBigInt> InternalFreedKb = new("internal_freed_kb");

        public static readonly Column<SqlBigInt> PeriodicFreedKb = new("periodic_freed_kb");

        public static readonly Column<SqlBigInt> SimulatedKb = new("simulated_kb");

        public static readonly Column<SqlFloat> SimulationBenefit = new("simulation_benefit");

        public static readonly Column<SqlBigInt> TotalKb = new("total_kb");

        public static readonly Column<SqlFloat> ValueOfMemory = new("value_of_memory");
    }
}
