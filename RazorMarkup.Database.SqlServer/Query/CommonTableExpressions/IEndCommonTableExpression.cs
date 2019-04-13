namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IEndCommonTableExpression<TEndType> : IQueryOperand<TEndType>
    {
        IWithClause<TEndType> And();
    }
}
