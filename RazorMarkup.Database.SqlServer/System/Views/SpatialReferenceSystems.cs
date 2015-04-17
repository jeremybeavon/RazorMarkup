using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SpatialReferenceSystems
    {
        public static readonly ViewName ViewName = new ViewName("sys.spatial_reference_systems");
        
        public static readonly Column<SqlNVarchar> AuthorityName = new Column<SqlNVarchar>("authority_name");
        
        public static readonly Column<SqlInt> AuthorizedSpatialReferenceId = new Column<SqlInt>("authorized_spatial_reference_id");
        
        public static readonly Column<SqlInt> SpatialReferenceId = new Column<SqlInt>("spatial_reference_id");
        
        public static readonly Column<SqlFloat> UnitConversionFactor = new Column<SqlFloat>("unit_conversion_factor");
        
        public static readonly Column<SqlNVarchar> UnitOfMeasure = new Column<SqlNVarchar>("unit_of_measure");
        
        public static readonly Column<SqlNVarchar> WellKnownText = new Column<SqlNVarchar>("well_known_text");
    }
}
