using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PlanGuides
    {
        public static readonly ViewName ViewName = new("sys.plan_guides");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlNVarchar> Hints = new("hints");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Parameters = new("parameters");

        public static readonly Column<SqlInt> PlanGuideId = new("plan_guide_id");

        public static readonly Column<SqlNVarchar> QueryText = new("query_text");

        public static readonly Column<SqlNVarchar> ScopeBatch = new("scope_batch");

        public static readonly Column<SqlInt> ScopeObjectId = new("scope_object_id");

        public static readonly Column<SqlTinyInt> ScopeType = new("scope_type");

        public static readonly Column<SqlNVarchar> ScopeTypeDesc = new("scope_type_desc");
    }
}
