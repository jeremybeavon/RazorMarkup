using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsVirtualAddressDump
    {
        public static readonly ViewName ViewName = new("sys.dm_os_virtual_address_dump");

        public static readonly Column<SqlVarbinary> RegionAllocationBaseAddress = new("region_allocation_base_address");

        public static readonly Column<SqlVarbinary> RegionAllocationProtection = new("region_allocation_protection");

        public static readonly Column<SqlVarbinary> RegionBaseAddress = new("region_base_address");

        public static readonly Column<SqlVarbinary> RegionCurrentProtection = new("region_current_protection");

        public static readonly Column<SqlBigInt> RegionSizeInBytes = new("region_size_in_bytes");

        public static readonly Column<SqlVarbinary> RegionState = new("region_state");

        public static readonly Column<SqlVarbinary> RegionType = new("region_type");
    }
}
