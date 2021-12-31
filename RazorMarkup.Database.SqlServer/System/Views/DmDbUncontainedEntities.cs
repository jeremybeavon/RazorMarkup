using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbUncontainedEntities
    {
        public static readonly ViewName ViewName = new("sys.dm_db_uncontained_entities");

        public static readonly Column<SqlInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlNVarchar> FeatureName = new("feature_name");

        public static readonly Column<SqlNVarchar> FeatureTypeName = new("feature_type_name");

        public static readonly Column<SqlInt> MajorId = new("major_id");

        public static readonly Column<SqlInt> StatementLineNumber = new("statement_line_number");

        public static readonly Column<SqlInt> StatementOffsetBegin = new("statement_offset_begin");

        public static readonly Column<SqlInt> StatementOffsetEnd = new("statement_offset_end");

        public static readonly Column<SqlNVarchar> StatementType = new("statement_type");
    }
}
