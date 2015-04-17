using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlIndexes
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_indexes");
        
        public static readonly Column<SqlBit> AllowPageLocks = new Column<SqlBit>("allow_page_locks");
        
        public static readonly Column<SqlBit> AllowRowLocks = new Column<SqlBit>("allow_row_locks");
        
        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
        
        public static readonly Column<SqlTinyInt> FillFactor = new Column<SqlTinyInt>("fill_factor");
        
        public static readonly Column<SqlNVarchar> FilterDefinition = new Column<SqlNVarchar>("filter_definition");
        
        public static readonly Column<SqlBit> HasFilter = new Column<SqlBit>("has_filter");
        
        public static readonly Column<SqlBit> IgnoreDupKey = new Column<SqlBit>("ignore_dup_key");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBit> IsDisabled = new Column<SqlBit>("is_disabled");
        
        public static readonly Column<SqlBit> IsHypothetical = new Column<SqlBit>("is_hypothetical");
        
        public static readonly Column<SqlBit> IsPadded = new Column<SqlBit>("is_padded");
        
        public static readonly Column<SqlBit> IsPrimaryKey = new Column<SqlBit>("is_primary_key");
        
        public static readonly Column<SqlBit> IsUnique = new Column<SqlBit>("is_unique");
        
        public static readonly Column<SqlBit> IsUniqueConstraint = new Column<SqlBit>("is_unique_constraint");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> PathId = new Column<SqlInt>("path_id");
        
        public static readonly Column<SqlChar> SecondaryType = new Column<SqlChar>("secondary_type");
        
        public static readonly Column<SqlNVarchar> SecondaryTypeDesc = new Column<SqlNVarchar>("secondary_type_desc");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlInt> UsingXmlIndexId = new Column<SqlInt>("using_xml_index_id");
        
        public static readonly Column<SqlTinyInt> XmlIndexType = new Column<SqlTinyInt>("xml_index_type");
        
        public static readonly Column<SqlNVarchar> XmlIndexTypeDescription = new Column<SqlNVarchar>("xml_index_type_description");
    }
}
