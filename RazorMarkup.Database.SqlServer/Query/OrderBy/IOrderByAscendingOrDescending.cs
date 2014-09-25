namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    public interface IOrderByAscendingOrDescending<TEndType> : IOrderByAnd<TEndType>
    {
        IOrderByAnd<TEndType> Ascending();

        IOrderByAnd<TEndType> Descending();
    }
}
