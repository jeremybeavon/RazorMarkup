namespace RazorMarkup.Database.SqlServer
{
    public sealed class FederationName : SqlString
    {
        public FederationName(string federationName)
            : base(federationName)
        {
        }
    }
}
