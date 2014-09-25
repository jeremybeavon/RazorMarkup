namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    public interface IOffsetFetchOnly<TEndType> : IHideObjectMethods
    {
        IEndOffsetClause<TEndType> Only();
    }
}
