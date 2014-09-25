namespace RazorMarkup.Database.SqlServer
{
    public sealed class AggregateName : SqlString
    {
        public AggregateName(string aggregateName)
            : base(aggregateName)
        {
        }
    }
}
