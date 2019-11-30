namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IEndCommonTableExpression<TEndCommonTableExpression> : IHideObjectMethods
    {
        IWithClause<ICommonTableExpressionEnd<TEndCommonTableExpression>> And();
    }
}
