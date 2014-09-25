namespace RazorMarkup.Database.SqlServer
{
    public sealed class CryptographicProviderName : SqlString
    {
        public CryptographicProviderName(string cryptographicProviderName)
            : base(cryptographicProviderName)
        {
        }
    }
}
