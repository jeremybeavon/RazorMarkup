namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IEndCommonTableExpression :
        IEndCommonTableExpression<IEndCommonTableExpression>,
        IQueryOperand<IEndQuery>
    {
    }
}
