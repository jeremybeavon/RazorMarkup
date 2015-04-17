using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLanguages
    {
        public static readonly ViewName ViewName = new ViewName("sys.syslanguages");
        
        public static readonly Column<SqlNVarchar> Alias = new Column<SqlNVarchar>("alias");
        
        public static readonly Column<SqlTinyInt> Datefirst = new Column<SqlTinyInt>("datefirst");
        
        public static readonly Column<SqlNChar> Dateformat = new Column<SqlNChar>("dateformat");
        
        public static readonly Column<SqlNVarchar> Days = new Column<SqlNVarchar>("days");
        
        public static readonly Column<SqlSmallInt> Langid = new Column<SqlSmallInt>("langid");
        
        public static readonly Column<SqlInt> Lcid = new Column<SqlInt>("lcid");
        
        public static readonly Column<SqlNVarchar> Months = new Column<SqlNVarchar>("months");
        
        public static readonly Column<SqlSmallInt> Msglangid = new Column<SqlSmallInt>("msglangid");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> Shortmonths = new Column<SqlNVarchar>("shortmonths");
        
        public static readonly Column<SqlInt> Upgrade = new Column<SqlInt>("upgrade");
    }
}
