namespace RazorMarkup.Database.SqlServer
{
    public sealed class SynonymName : SqlString
    {
        public SynonymName(string synonymName)
            : base(synonymName)
        {
        }
    }
}
