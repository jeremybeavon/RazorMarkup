using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMissingIndexDetails
    {
        public static readonly ViewName ViewName = new("sys.dm_db_missing_index_details");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlNVarchar> EqualityColumns = new("equality_columns");

        public static readonly Column<SqlNVarchar> IncludedColumns = new("included_columns");

        public static readonly Column<SqlInt> IndexHandle = new("index_handle");

        public static readonly Column<SqlNVarchar> InequalityColumns = new("inequality_columns");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlNVarchar> Statement = new("statement");
    }
}
