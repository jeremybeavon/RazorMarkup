using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SpatialIndexTessellations
    {
        public static readonly ViewName ViewName = new ViewName("sys.spatial_index_tessellations");
        
        public static readonly Column<SqlFloat> BoundingBoxXmax = new Column<SqlFloat>("bounding_box_xmax");
        
        public static readonly Column<SqlFloat> BoundingBoxXmin = new Column<SqlFloat>("bounding_box_xmin");
        
        public static readonly Column<SqlFloat> BoundingBoxYmax = new Column<SqlFloat>("bounding_box_ymax");
        
        public static readonly Column<SqlFloat> BoundingBoxYmin = new Column<SqlFloat>("bounding_box_ymin");
        
        public static readonly Column<SqlInt> CellsPerObject = new Column<SqlInt>("cells_per_object");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlSmallInt> Level_1Grid = new Column<SqlSmallInt>("level_1_grid");
        
        public static readonly Column<SqlNVarchar> Level_1GridDesc = new Column<SqlNVarchar>("level_1_grid_desc");
        
        public static readonly Column<SqlSmallInt> Level_2Grid = new Column<SqlSmallInt>("level_2_grid");
        
        public static readonly Column<SqlNVarchar> Level_2GridDesc = new Column<SqlNVarchar>("level_2_grid_desc");
        
        public static readonly Column<SqlSmallInt> Level_3Grid = new Column<SqlSmallInt>("level_3_grid");
        
        public static readonly Column<SqlNVarchar> Level_3GridDesc = new Column<SqlNVarchar>("level_3_grid_desc");
        
        public static readonly Column<SqlSmallInt> Level_4Grid = new Column<SqlSmallInt>("level_4_grid");
        
        public static readonly Column<SqlNVarchar> Level_4GridDesc = new Column<SqlNVarchar>("level_4_grid_desc");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlNVarchar> TessellationScheme = new Column<SqlNVarchar>("tessellation_scheme");
    }
}
