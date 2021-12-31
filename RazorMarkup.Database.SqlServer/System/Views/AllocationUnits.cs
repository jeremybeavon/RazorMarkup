using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AllocationUnits
    {
        public static readonly ViewName ViewName = new("sys.allocation_units");

        public static readonly Column<SqlBigInt> AllocationUnitId = new("allocation_unit_id");

        public static readonly Column<SqlBigInt> ContainerId = new("container_id");

        public static readonly Column<SqlBigInt> DataPages = new("data_pages");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlBigInt> TotalPages = new("total_pages");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");

        public static readonly Column<SqlBigInt> UsedPages = new("used_pages");
    }
}
