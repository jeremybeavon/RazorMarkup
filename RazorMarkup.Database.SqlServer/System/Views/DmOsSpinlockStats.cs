using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSpinlockStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_spinlock_stats");
        
        public static readonly Column<SqlInt> Backoffs = new Column<SqlInt>("backoffs");
        
        public static readonly Column<SqlBigInt> Collisions = new Column<SqlBigInt>("collisions");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBigInt> SleepTime = new Column<SqlBigInt>("sleep_time");
        
        public static readonly Column<SqlBigInt> Spins = new Column<SqlBigInt>("spins");
        
        public static readonly Column<SqlReal> SpinsPerCollision = new Column<SqlReal>("spins_per_collision");
    }
}
