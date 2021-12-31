using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Stats
    {
        public static readonly ViewName ViewName = new("sys.stats");

        public static readonly Column<SqlBit> AutoCreated = new("auto_created");

        public static readonly Column<SqlNVarchar> FilterDefinition = new("filter_definition");

        public static readonly Column<SqlBit> HasFilter = new("has_filter");

        public static readonly Column<SqlBit> IsTemporary = new("is_temporary");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBit> NoRecompute = new("no_recompute");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> StatsId = new("stats_id");

        public static readonly Column<SqlBit> UserCreated = new("user_created");
    }
}
