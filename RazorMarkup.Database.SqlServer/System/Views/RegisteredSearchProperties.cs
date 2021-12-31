using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RegisteredSearchProperties
    {
        public static readonly ViewName ViewName = new("sys.registered_search_properties");

        public static readonly Column<SqlNVarchar> PropertyDescription = new("property_description");

        public static readonly Column<SqlInt> PropertyId = new("property_id");

        public static readonly Column<SqlInt> PropertyIntId = new("property_int_id");

        public static readonly Column<SqlInt> PropertyListId = new("property_list_id");

        public static readonly Column<SqlNVarchar> PropertyName = new("property_name");

        public static readonly Column<SqlUniqueIdentifier> PropertySetGuid = new("property_set_guid");
    }
}
