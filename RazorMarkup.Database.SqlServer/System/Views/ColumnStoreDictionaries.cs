using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnStoreDictionaries
    {
        public static readonly ViewName ViewName = new("sys.column_store_dictionaries");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> DictionaryId = new("dictionary_id");

        public static readonly Column<SqlBigInt> EntryCount = new("entry_count");

        public static readonly Column<SqlBigInt> Flags = new("flags");

        public static readonly Column<SqlBigInt> HobtId = new("hobt_id");

        public static readonly Column<SqlInt> LastId = new("last_id");

        public static readonly Column<SqlBigInt> OnDiskSize = new("on_disk_size");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlInt> Type = new("type");

        public static readonly Column<SqlInt> Version = new("version");
    }
}
