using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ParameterTypeUsages
    {
        public static readonly ViewName ViewName = new("sys.parameter_type_usages");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParameterId = new("parameter_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
