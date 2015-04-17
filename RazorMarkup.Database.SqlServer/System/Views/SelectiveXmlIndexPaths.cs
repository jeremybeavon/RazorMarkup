using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SelectiveXmlIndexPaths
    {
        public static readonly ViewName ViewName = new ViewName("sys.selective_xml_index_paths");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBit> IsNode = new Column<SqlBit>("is_node");
        
        public static readonly Column<SqlBit> IsSingleton = new Column<SqlBit>("is_singleton");
        
        public static readonly Column<SqlBit> IsXqueryMaxLengthInferred = new Column<SqlBit>("is_xquery_max_length_inferred");
        
        public static readonly Column<SqlBit> IsXqueryTypeInferred = new Column<SqlBit>("is_xquery_type_inferred");
        
        public static readonly Column<SqlSmallInt> MaxLength = new Column<SqlSmallInt>("max_length");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
        
        public static readonly Column<SqlInt> PathId = new Column<SqlInt>("path_id");
        
        public static readonly Column<SqlTinyInt> PathType = new Column<SqlTinyInt>("path_type");
        
        public static readonly Column<SqlNVarchar> PathTypeDesc = new Column<SqlNVarchar>("path_type_desc");
        
        public static readonly Column<SqlTinyInt> Precision = new Column<SqlTinyInt>("precision");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlTinyInt> SystemTypeId = new Column<SqlTinyInt>("system_type_id");
        
        public static readonly Column<SqlTinyInt> UserTypeId = new Column<SqlTinyInt>("user_type_id");
        
        public static readonly Column<SqlInt> XmlComponentId = new Column<SqlInt>("xml_component_id");
        
        public static readonly Column<SqlInt> XqueryMaxLength = new Column<SqlInt>("xquery_max_length");
        
        public static readonly Column<SqlNVarchar> XqueryTypeDescription = new Column<SqlNVarchar>("xquery_type_description");
    }
}
