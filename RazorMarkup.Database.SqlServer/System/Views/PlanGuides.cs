using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PlanGuides
    {
        public static readonly ViewName ViewName = new ViewName("sys.plan_guides");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlNVarchar> Hints = new Column<SqlNVarchar>("hints");
        
        public static readonly Column<SqlBit> IsDisabled = new Column<SqlBit>("is_disabled");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Parameters = new Column<SqlNVarchar>("parameters");
        
        public static readonly Column<SqlInt> PlanGuideId = new Column<SqlInt>("plan_guide_id");
        
        public static readonly Column<SqlNVarchar> QueryText = new Column<SqlNVarchar>("query_text");
        
        public static readonly Column<SqlNVarchar> ScopeBatch = new Column<SqlNVarchar>("scope_batch");
        
        public static readonly Column<SqlInt> ScopeObjectId = new Column<SqlInt>("scope_object_id");
        
        public static readonly Column<SqlTinyInt> ScopeType = new Column<SqlTinyInt>("scope_type");
        
        public static readonly Column<SqlNVarchar> ScopeTypeDesc = new Column<SqlNVarchar>("scope_type_desc");
    }
}
