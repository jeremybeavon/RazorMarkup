namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    public interface IOrderByWithCollate<TEndType> : IOrderByAscendingOrDescending<TEndType>
    {
        IOrderByAscendingOrDescending<TEndType> WithCollate(CollationName collationName);
    }
}
