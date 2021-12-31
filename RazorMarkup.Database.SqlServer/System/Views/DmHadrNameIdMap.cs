using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrNameIdMap
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_name_id_map");

        public static readonly Column<SqlNVarchar> AgGroupId = new("ag_group_id");

        public static readonly Column<SqlUniqueIdentifier> AgId = new("ag_id");

        public static readonly Column<SqlNVarchar> AgName = new("ag_name");

        public static readonly Column<SqlNVarchar> AgResourceId = new("ag_resource_id");
    }
}
