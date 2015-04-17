using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RegisteredSearchProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.registered_search_properties");
        
        public static readonly Column<SqlNVarchar> PropertyDescription = new Column<SqlNVarchar>("property_description");
        
        public static readonly Column<SqlInt> PropertyId = new Column<SqlInt>("property_id");
        
        public static readonly Column<SqlInt> PropertyIntId = new Column<SqlInt>("property_int_id");
        
        public static readonly Column<SqlInt> PropertyListId = new Column<SqlInt>("property_list_id");
        
        public static readonly Column<SqlNVarchar> PropertyName = new Column<SqlNVarchar>("property_name");
        
        public static readonly Column<SqlUniqueIdentifier> PropertySetGuid = new Column<SqlUniqueIdentifier>("property_set_guid");
    }
}
