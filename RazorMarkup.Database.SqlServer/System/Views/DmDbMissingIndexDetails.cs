using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMissingIndexDetails
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_missing_index_details");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlNVarchar> EqualityColumns = new Column<SqlNVarchar>("equality_columns");
        
        public static readonly Column<SqlNVarchar> IncludedColumns = new Column<SqlNVarchar>("included_columns");
        
        public static readonly Column<SqlInt> IndexHandle = new Column<SqlInt>("index_handle");
        
        public static readonly Column<SqlNVarchar> InequalityColumns = new Column<SqlNVarchar>("inequality_columns");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlNVarchar> Statement = new Column<SqlNVarchar>("statement");
    }
}
