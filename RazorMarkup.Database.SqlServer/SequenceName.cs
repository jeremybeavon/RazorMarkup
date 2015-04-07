namespace RazorMarkup.Database.SqlServer
{
    public sealed class SequenceName : SqlString
    {
        public SequenceName(string sequenceName)
            : base(sequenceName)
        {
        }
    }
}
