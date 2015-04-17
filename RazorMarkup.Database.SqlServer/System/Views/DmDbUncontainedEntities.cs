using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbUncontainedEntities
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_uncontained_entities");
        
        public static readonly Column<SqlInt> Class = new Column<SqlInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlNVarchar> FeatureName = new Column<SqlNVarchar>("feature_name");
        
        public static readonly Column<SqlNVarchar> FeatureTypeName = new Column<SqlNVarchar>("feature_type_name");
        
        public static readonly Column<SqlInt> MajorId = new Column<SqlInt>("major_id");
        
        public static readonly Column<SqlInt> StatementLineNumber = new Column<SqlInt>("statement_line_number");
        
        public static readonly Column<SqlInt> StatementOffsetBegin = new Column<SqlInt>("statement_offset_begin");
        
        public static readonly Column<SqlInt> StatementOffsetEnd = new Column<SqlInt>("statement_offset_end");
        
        public static readonly Column<SqlNVarchar> StatementType = new Column<SqlNVarchar>("statement_type");
    }
}
