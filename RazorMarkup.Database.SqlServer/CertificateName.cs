namespace RazorMarkup.Database.SqlServer
{
    public sealed class CertificateName : SqlString
    {
        public CertificateName(string certificateName)
            : base(certificateName)
        {
        }
    }
}
