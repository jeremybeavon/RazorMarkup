namespace RazorMarkup.Database.SqlServer
{
    public sealed class CredentialName : SqlString
    {
        public CredentialName(string credentialName)
            : base(credentialName)
        {
        }
    }
}
