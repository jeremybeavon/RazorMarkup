namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IQueryGroupEnd<TEndType> : IHideObjectMethods
    {
        IEndQueryGroup<TEndType> OperatorGroup();
    }
}
