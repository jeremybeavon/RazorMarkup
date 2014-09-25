namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IQueryOperator<TEndType> : IHideObjectMethods
    {
        IQueryOperand<TEndType> Union();

        IQueryOperand<TEndType> UnionAll();

        IQueryOperand<TEndType> Except();

        IQueryOperand<TEndType> Intersect();
    }
}
