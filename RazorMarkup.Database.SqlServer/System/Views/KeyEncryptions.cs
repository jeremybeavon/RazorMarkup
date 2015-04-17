using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class KeyEncryptions
    {
        public static readonly ViewName ViewName = new ViewName("sys.key_encryptions");
        
        public static readonly Column<SqlVarbinary> CryptProperty = new Column<SqlVarbinary>("crypt_property");
        
        public static readonly Column<SqlChar> CryptType = new Column<SqlChar>("crypt_type");
        
        public static readonly Column<SqlNVarchar> CryptTypeDesc = new Column<SqlNVarchar>("crypt_type_desc");
        
        public static readonly Column<SqlInt> KeyId = new Column<SqlInt>("key_id");
        
        public static readonly Column<SqlVarbinary> Thumbprint = new Column<SqlVarbinary>("thumbprint");
    }
}
