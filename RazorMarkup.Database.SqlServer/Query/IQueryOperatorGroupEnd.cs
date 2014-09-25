namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IQueryOperatorGroupEnd<TEndType> : IHideObjectMethods
    {
        IEndQueryOperatorGroup<TEndType> OperatorGroup();
    }
}
