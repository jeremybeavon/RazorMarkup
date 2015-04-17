using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Stats
    {
        public static readonly ViewName ViewName = new ViewName("sys.stats");
        
        public static readonly Column<SqlBit> AutoCreated = new Column<SqlBit>("auto_created");
        
        public static readonly Column<SqlNVarchar> FilterDefinition = new Column<SqlNVarchar>("filter_definition");
        
        public static readonly Column<SqlBit> HasFilter = new Column<SqlBit>("has_filter");
        
        public static readonly Column<SqlBit> IsTemporary = new Column<SqlBit>("is_temporary");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBit> NoRecompute = new Column<SqlBit>("no_recompute");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> StatsId = new Column<SqlInt>("stats_id");
        
        public static readonly Column<SqlBit> UserCreated = new Column<SqlBit>("user_created");
    }
}
