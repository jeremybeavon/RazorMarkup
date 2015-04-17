using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Triggers
    {
        public static readonly ViewName ViewName = new ViewName("sys.triggers");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlBit> IsDisabled = new Column<SqlBit>("is_disabled");
        
        public static readonly Column<SqlBit> IsInsteadOfTrigger = new Column<SqlBit>("is_instead_of_trigger");
        
        public static readonly Column<SqlBit> IsMsShipped = new Column<SqlBit>("is_ms_shipped");
        
        public static readonly Column<SqlBit> IsNotForReplication = new Column<SqlBit>("is_not_for_replication");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlTinyInt> ParentClass = new Column<SqlTinyInt>("parent_class");
        
        public static readonly Column<SqlNVarchar> ParentClassDesc = new Column<SqlNVarchar>("parent_class_desc");
        
        public static readonly Column<SqlInt> ParentId = new Column<SqlInt>("parent_id");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
