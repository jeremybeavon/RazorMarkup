using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class KeyEncryptions
    {
        public static readonly ViewName ViewName = new("sys.key_encryptions");

        public static readonly Column<SqlVarbinary> CryptProperty = new("crypt_property");

        public static readonly Column<SqlChar> CryptType = new("crypt_type");

        public static readonly Column<SqlNVarchar> CryptTypeDesc = new("crypt_type_desc");

        public static readonly Column<SqlInt> KeyId = new("key_id");

        public static readonly Column<SqlVarbinary> Thumbprint = new("thumbprint");
    }
}
