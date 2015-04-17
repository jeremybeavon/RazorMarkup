using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscomments
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscomments");
        
        public static readonly Column<SqlSmallInt> Colid = new Column<SqlSmallInt>("colid");
        
        public static readonly Column<SqlBit> Compressed = new Column<SqlBit>("compressed");
        
        public static readonly Column<SqlVarbinary> Ctext = new Column<SqlVarbinary>("ctext");
        
        public static readonly Column<SqlBit> Encrypted = new Column<SqlBit>("encrypted");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlSmallInt> Language = new Column<SqlSmallInt>("language");
        
        public static readonly Column<SqlSmallInt> Number = new Column<SqlSmallInt>("number");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlNVarchar> Text = new Column<SqlNVarchar>("text");
        
        public static readonly Column<SqlSmallInt> Texttype = new Column<SqlSmallInt>("texttype");
    }
}
