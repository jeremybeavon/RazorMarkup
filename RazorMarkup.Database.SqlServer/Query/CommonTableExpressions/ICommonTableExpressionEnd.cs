namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface ICommonTableExpressionEnd : IHideObjectMethods
    {
        IEndCommonTableExpression<IEndQuery> With();
    }
}
