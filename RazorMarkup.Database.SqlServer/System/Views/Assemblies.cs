using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Assemblies
    {
        public static readonly ViewName ViewName = new("sys.assemblies");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlTinyInt, AssembliesPermissionSet> PermissionSet =
            new("permission_set");

        public static readonly Column<SqlNVarchar, AssembliesPermissionSetDescriptions> PermissionSetDescription =
             new("permission_set_desc");

        public static readonly Column<SqlBit> IsVisible = new("is_visible");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlBit> IsUserDefined = new("is_user_defined");
    }
}
