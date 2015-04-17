using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Certificates
    {
        public static readonly ViewName ViewName = new ViewName("sys.certificates");
        
        public static readonly Column<SqlNVarchar> AttestedBy = new Column<SqlNVarchar>("attested_by");
        
        public static readonly Column<SqlNVarchar> CertSerialNumber = new Column<SqlNVarchar>("cert_serial_number");
        
        public static readonly Column<SqlInt> CertificateId = new Column<SqlInt>("certificate_id");
        
        public static readonly Column<SqlDateTime> ExpiryDate = new Column<SqlDateTime>("expiry_date");
        
        public static readonly Column<SqlBit> IsActiveForBeginDialog = new Column<SqlBit>("is_active_for_begin_dialog");
        
        public static readonly Column<SqlNVarchar> IssuerName = new Column<SqlNVarchar>("issuer_name");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlChar> PvtKeyEncryptionType = new Column<SqlChar>("pvt_key_encryption_type");
        
        public static readonly Column<SqlNVarchar> PvtKeyEncryptionTypeDesc = new Column<SqlNVarchar>("pvt_key_encryption_type_desc");
        
        public static readonly Column<SqlDateTime> PvtKeyLastBackupDate = new Column<SqlDateTime>("pvt_key_last_backup_date");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlDateTime> StartDate = new Column<SqlDateTime>("start_date");
        
        public static readonly Column<SqlNVarchar> StringSid = new Column<SqlNVarchar>("string_sid");
        
        public static readonly Column<SqlNVarchar> Subject = new Column<SqlNVarchar>("subject");
        
        public static readonly Column<SqlVarbinary> Thumbprint = new Column<SqlVarbinary>("thumbprint");
    }
}
