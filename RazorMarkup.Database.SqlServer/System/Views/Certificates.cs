using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Certificates
    {
        public static readonly ViewName ViewName = new("sys.certificates");

        public static readonly Column<SqlNVarchar> AttestedBy = new("attested_by");

        public static readonly Column<SqlNVarchar> CertSerialNumber = new("cert_serial_number");

        public static readonly Column<SqlInt> CertificateId = new("certificate_id");

        public static readonly Column<SqlDateTime> ExpiryDate = new("expiry_date");

        public static readonly Column<SqlBit> IsActiveForBeginDialog = new("is_active_for_begin_dialog");

        public static readonly Column<SqlNVarchar> IssuerName = new("issuer_name");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlChar> PvtKeyEncryptionType = new("pvt_key_encryption_type");

        public static readonly Column<SqlNVarchar> PvtKeyEncryptionTypeDesc = new("pvt_key_encryption_type_desc");

        public static readonly Column<SqlDateTime> PvtKeyLastBackupDate = new("pvt_key_last_backup_date");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlDateTime> StartDate = new("start_date");

        public static readonly Column<SqlNVarchar> StringSid = new("string_sid");

        public static readonly Column<SqlNVarchar> Subject = new("subject");

        public static readonly Column<SqlVarbinary> Thumbprint = new("thumbprint");
    }
}
