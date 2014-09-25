namespace RazorMarkup.Database.SqlServer
{
    public sealed class AsymmetricKeyName : SqlString
    {
        public AsymmetricKeyName(string asymmetricKeyName)
            : base(asymmetricKeyName)
        {
        }
    }
}
