using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSpinlockStats
    {
        public static readonly ViewName ViewName = new("sys.dm_os_spinlock_stats");

        public static readonly Column<SqlInt> Backoffs = new("backoffs");

        public static readonly Column<SqlBigInt> Collisions = new("collisions");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBigInt> SleepTime = new("sleep_time");

        public static readonly Column<SqlBigInt> Spins = new("spins");

        public static readonly Column<SqlReal> SpinsPerCollision = new("spins_per_collision");
    }
}
