using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AllocationUnits
    {
        public static readonly ViewName ViewName = new ViewName("sys.allocation_units");
        
        public static readonly Column<SqlBigInt> AllocationUnitId = new Column<SqlBigInt>("allocation_unit_id");
        
        public static readonly Column<SqlBigInt> ContainerId = new Column<SqlBigInt>("container_id");
        
        public static readonly Column<SqlBigInt> DataPages = new Column<SqlBigInt>("data_pages");
        
        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
        
        public static readonly Column<SqlBigInt> TotalPages = new Column<SqlBigInt>("total_pages");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlBigInt> UsedPages = new Column<SqlBigInt>("used_pages");
    }
}
