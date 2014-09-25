using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class Assemblies
    {
        public static readonly ViewName ViewName = new ViewName("sys.assemblies");

        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");

        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");

        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");

        public static readonly Column<SqlTinyInt, AssembliesPermissionSet> PermissionSet =
            new Column<SqlTinyInt, AssembliesPermissionSet>("permission_set");

        public static readonly Column<SqlNVarchar, AssembliesPermissionSetDescriptions> PermissionSetDescription =
             new Column<SqlNVarchar, AssembliesPermissionSetDescriptions>("permission_set_desc");

        public static readonly Column<SqlBit> IsVisible = new Column<SqlBit>("is_visible");

        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");

        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");

        public static readonly Column<SqlBit> IsUserDefined = new Column<SqlBit>("is_user_defined");
    }
}
