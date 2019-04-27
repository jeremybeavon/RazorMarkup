namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface ICommonTableExpression<TEndType> : IHideObjectMethods
    {
        IQueryOperand<TEndType> As();
    }
}
