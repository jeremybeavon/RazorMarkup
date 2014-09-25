namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithPercent<TEndType> : ISelectClauseWithTies<TEndType>
    {
        ISelectClauseWithTies<TEndType> Percent();
    }
}
