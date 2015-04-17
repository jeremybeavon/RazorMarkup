using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemParameters
    {
        public static readonly ViewName ViewName = new ViewName("sys.system_parameters");
        
        public static readonly Column<SqlVariant> DefaultValue = new Column<SqlVariant>("default_value");
        
        public static readonly Column<SqlBit> HasDefaultValue = new Column<SqlBit>("has_default_value");
        
        public static readonly Column<SqlBit> IsCursorRef = new Column<SqlBit>("is_cursor_ref");
        
        public static readonly Column<SqlBit> IsOutput = new Column<SqlBit>("is_output");
        
        public static readonly Column<SqlBit> IsReadonly = new Column<SqlBit>("is_readonly");
        
        public static readonly Column<SqlBit> IsXmlDocument = new Column<SqlBit>("is_xml_document");
        
        public static readonly Column<SqlSmallInt> MaxLength = new Column<SqlSmallInt>("max_length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParameterId = new Column<SqlInt>("parameter_id");
        
        public static readonly Column<SqlTinyInt> Precision = new Column<SqlTinyInt>("precision");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlTinyInt> SystemTypeId = new Column<SqlTinyInt>("system_type_id");
        
        public static readonly Column<SqlInt> UserTypeId = new Column<SqlInt>("user_type_id");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
