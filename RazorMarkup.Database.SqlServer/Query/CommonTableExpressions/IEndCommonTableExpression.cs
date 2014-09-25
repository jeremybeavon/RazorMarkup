namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IEndCommonTableExpression : IQueryOperand<IEndQuery>
    {
        IWithClause And();
    }
}
