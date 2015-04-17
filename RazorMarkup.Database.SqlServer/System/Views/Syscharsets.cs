using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscharsets
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscharsets");
        
        public static readonly Column<SqlVarbinary> Binarydefinition = new Column<SqlVarbinary>("binarydefinition");
        
        public static readonly Column<SqlTinyInt> Csid = new Column<SqlTinyInt>("csid");
        
        public static readonly Column<SqlImage> Definition = new Column<SqlImage>("definition");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlTinyInt> Id = new Column<SqlTinyInt>("id");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlSmallInt> Type = new Column<SqlSmallInt>("type");
    }
}
