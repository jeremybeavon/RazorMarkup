namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    public interface IOrderByCollate<TEndType> : IOrderByAscendingOrDescending<TEndType>
    {
        IOrderByAscendingOrDescending<TEndType> Collate(CollationName collationName);
    }
}
