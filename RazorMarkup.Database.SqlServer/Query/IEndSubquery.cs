namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndSubquery<TEndType> : IHideObjectMethods
    {
        TEndType Subquery();
    }
}
