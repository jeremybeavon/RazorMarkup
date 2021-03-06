using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ComputedColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.computed_columns");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> DefaultObjectId = new Column<SqlInt>("default_object_id");
        
        public static readonly Column<SqlNVarchar> Definition = new Column<SqlNVarchar>("definition");
        
        public static readonly Column<SqlBit> IsAnsiPadded = new Column<SqlBit>("is_ansi_padded");
        
        public static readonly Column<SqlBit> IsColumnSet = new Column<SqlBit>("is_column_set");
        
        public static readonly Column<SqlBit> IsComputed = new Column<SqlBit>("is_computed");
        
        public static readonly Column<SqlBit> IsDtsReplicated = new Column<SqlBit>("is_dts_replicated");
        
        public static readonly Column<SqlBit> IsFilestream = new Column<SqlBit>("is_filestream");
        
        public static readonly Column<SqlBit> IsIdentity = new Column<SqlBit>("is_identity");
        
        public static readonly Column<SqlBit> IsMergePublished = new Column<SqlBit>("is_merge_published");
        
        public static readonly Column<SqlBit> IsNonSqlSubscribed = new Column<SqlBit>("is_non_sql_subscribed");
        
        public static readonly Column<SqlBit> IsNullable = new Column<SqlBit>("is_nullable");
        
        public static readonly Column<SqlBit> IsPersisted = new Column<SqlBit>("is_persisted");
        
        public static readonly Column<SqlBit> IsReplicated = new Column<SqlBit>("is_replicated");
        
        public static readonly Column<SqlBit> IsRowguidcol = new Column<SqlBit>("is_rowguidcol");
        
        public static readonly Column<SqlBit> IsSparse = new Column<SqlBit>("is_sparse");
        
        public static readonly Column<SqlBit> IsXmlDocument = new Column<SqlBit>("is_xml_document");
        
        public static readonly Column<SqlSmallInt> MaxLength = new Column<SqlSmallInt>("max_length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlTinyInt> Precision = new Column<SqlTinyInt>("precision");
        
        public static readonly Column<SqlInt> RuleObjectId = new Column<SqlInt>("rule_object_id");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlTinyInt> SystemTypeId = new Column<SqlTinyInt>("system_type_id");
        
        public static readonly Column<SqlInt> UserTypeId = new Column<SqlInt>("user_type_id");
        
        public static readonly Column<SqlBit> UsesDatabaseCollation = new Column<SqlBit>("uses_database_collation");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
