using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class BackupStatementTests
    {
        [TestMethod]
        public void Test_BackupMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"BACKUP MASTER KEY TO FILE = 'C:\TEST'
ENCRYPTION BY PASSWORD = 'TESTPASSWORD'";
            Sql.Backup().MasterKey().ToFile(@"C:\TEST").EncryptionByPassword("TESTPASSWORD")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_BackupServiceMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"BACKUP SERVICE MASTER KEY TO FILE = 'C:\TEST'
ENCRYPTION BY PASSWORD = 'TESTPASSWORD'";
            Sql.Backup().ServiceMasterKey().ToFile(@"C:\TEST").EncryptionByPassword("TESTPASSWORD")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_BackupCertificate_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"BACKUP CERTIFICATE certificate1 TO FILE = 'C:\TEST'";
            Sql.Backup().Certificate(new CertificateName("certificate1")).ToFile(@"C:\TEST")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_BackupCertificateWithEncryptionPassword_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"BACKUP CERTIFICATE certificate1 TO FILE = 'C:\TEST'
WITH PRIVATE KEY
(
    FILE = 'C:\PRIVATETEST',
    ENCRYPTION BY PASSWORD = 'ENCRYPTIONPASSWORD'
)";
            Sql.Backup().Certificate(new CertificateName("certificate1")).ToFile(@"C:\TEST")
                .WithPrivateKey().File(@"C:\PRIVATETEST").AndEncryptionByPassword("ENCRYPTIONPASSWORD")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_BackupCertificateWithDecryptionPassword_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"BACKUP CERTIFICATE certificate1 TO FILE = 'C:\TEST'
WITH PRIVATE KEY
(
    FILE = 'C:\PRIVATETEST',
    ENCRYPTION BY PASSWORD = 'ENCRYPTIONPASSWORD',
    DECRYPTION BY PASSWORD = 'DECRYPTIONPASSWORD'
)";
            Sql.Backup().Certificate(new CertificateName("certificate1")).ToFile(@"C:\TEST")
                .WithPrivateKey().File(@"C:\PRIVATETEST").AndEncryptionByPassword("ENCRYPTIONPASSWORD")
                .AndDecryptionByPassword("DECRYPTIONPASSWORD")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }
    }
}
