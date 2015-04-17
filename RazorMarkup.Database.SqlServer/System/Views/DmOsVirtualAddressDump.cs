using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsVirtualAddressDump
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_virtual_address_dump");
        
        public static readonly Column<SqlVarbinary> RegionAllocationBaseAddress = new Column<SqlVarbinary>("region_allocation_base_address");
        
        public static readonly Column<SqlVarbinary> RegionAllocationProtection = new Column<SqlVarbinary>("region_allocation_protection");
        
        public static readonly Column<SqlVarbinary> RegionBaseAddress = new Column<SqlVarbinary>("region_base_address");
        
        public static readonly Column<SqlVarbinary> RegionCurrentProtection = new Column<SqlVarbinary>("region_current_protection");
        
        public static readonly Column<SqlBigInt> RegionSizeInBytes = new Column<SqlBigInt>("region_size_in_bytes");
        
        public static readonly Column<SqlVarbinary> RegionState = new Column<SqlVarbinary>("region_state");
        
        public static readonly Column<SqlVarbinary> RegionType = new Column<SqlVarbinary>("region_type");
    }
}
