using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ExtendedProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.extended_properties");
        
        public static readonly Column<SqlTinyInt> Class = new Column<SqlTinyInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlInt> MajorId = new Column<SqlInt>("major_id");
        
        public static readonly Column<SqlInt> MinorId = new Column<SqlInt>("minor_id");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlVariant> Value = new Column<SqlVariant>("value");
    }
}
