using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnStoreDictionaries
    {
        public static readonly ViewName ViewName = new ViewName("sys.column_store_dictionaries");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> DictionaryId = new Column<SqlInt>("dictionary_id");
        
        public static readonly Column<SqlBigInt> EntryCount = new Column<SqlBigInt>("entry_count");
        
        public static readonly Column<SqlBigInt> Flags = new Column<SqlBigInt>("flags");
        
        public static readonly Column<SqlBigInt> HobtId = new Column<SqlBigInt>("hobt_id");
        
        public static readonly Column<SqlInt> LastId = new Column<SqlInt>("last_id");
        
        public static readonly Column<SqlBigInt> OnDiskSize = new Column<SqlBigInt>("on_disk_size");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlInt> Type = new Column<SqlInt>("type");
        
        public static readonly Column<SqlInt> Version = new Column<SqlInt>("version");
    }
}
