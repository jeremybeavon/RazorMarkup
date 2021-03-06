using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CryptProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.crypt_properties");
        
        public static readonly Column<SqlTinyInt> Class = new Column<SqlTinyInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlVarbinary> CryptProperty = new Column<SqlVarbinary>("crypt_property");
        
        public static readonly Column<SqlChar> CryptType = new Column<SqlChar>("crypt_type");
        
        public static readonly Column<SqlNVarchar> CryptTypeDesc = new Column<SqlNVarchar>("crypt_type_desc");
        
        public static readonly Column<SqlInt> MajorId = new Column<SqlInt>("major_id");
        
        public static readonly Column<SqlVarbinary> Thumbprint = new Column<SqlVarbinary>("thumbprint");
    }
}
