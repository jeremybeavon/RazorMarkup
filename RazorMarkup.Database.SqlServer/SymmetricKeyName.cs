namespace RazorMarkup.Database.SqlServer
{
    public sealed class SymmetricKeyName : SqlString
    {
        public SymmetricKeyName(string symmetricKeyName)
            : base(symmetricKeyName)
        {
        }
    }
}
