using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CryptProperties
    {
        public static readonly ViewName ViewName = new("sys.crypt_properties");

        public static readonly Column<SqlTinyInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlVarbinary> CryptProperty = new("crypt_property");

        public static readonly Column<SqlChar> CryptType = new("crypt_type");

        public static readonly Column<SqlNVarchar> CryptTypeDesc = new("crypt_type_desc");

        public static readonly Column<SqlInt> MajorId = new("major_id");

        public static readonly Column<SqlVarbinary> Thumbprint = new("thumbprint");
    }
}
