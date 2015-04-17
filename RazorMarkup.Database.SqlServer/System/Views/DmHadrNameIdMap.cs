using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrNameIdMap
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_name_id_map");
        
        public static readonly Column<SqlNVarchar> AgGroupId = new Column<SqlNVarchar>("ag_group_id");
        
        public static readonly Column<SqlUniqueIdentifier> AgId = new Column<SqlUniqueIdentifier>("ag_id");
        
        public static readonly Column<SqlNVarchar> AgName = new Column<SqlNVarchar>("ag_name");
        
        public static readonly Column<SqlNVarchar> AgResourceId = new Column<SqlNVarchar>("ag_resource_id");
    }
}
