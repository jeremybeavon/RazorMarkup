using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SpatialIndexTessellations
    {
        public static readonly ViewName ViewName = new("sys.spatial_index_tessellations");

        public static readonly Column<SqlFloat> BoundingBoxXmax = new("bounding_box_xmax");

        public static readonly Column<SqlFloat> BoundingBoxXmin = new("bounding_box_xmin");

        public static readonly Column<SqlFloat> BoundingBoxYmax = new("bounding_box_ymax");

        public static readonly Column<SqlFloat> BoundingBoxYmin = new("bounding_box_ymin");

        public static readonly Column<SqlInt> CellsPerObject = new("cells_per_object");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlSmallInt> Level_1Grid = new("level_1_grid");

        public static readonly Column<SqlNVarchar> Level_1GridDesc = new("level_1_grid_desc");

        public static readonly Column<SqlSmallInt> Level_2Grid = new("level_2_grid");

        public static readonly Column<SqlNVarchar> Level_2GridDesc = new("level_2_grid_desc");

        public static readonly Column<SqlSmallInt> Level_3Grid = new("level_3_grid");

        public static readonly Column<SqlNVarchar> Level_3GridDesc = new("level_3_grid_desc");

        public static readonly Column<SqlSmallInt> Level_4Grid = new("level_4_grid");

        public static readonly Column<SqlNVarchar> Level_4GridDesc = new("level_4_grid_desc");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlNVarchar> TessellationScheme = new("tessellation_scheme");
    }
}
