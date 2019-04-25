using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpressionEnd : ICommonTableExpressionEnd<IEndCommonTableExpression>
    {
        private readonly IEndCommonTableExpression end;
        private readonly WithClauseBuilder statement;

        public CommonTableExpressionEnd(WithClauseBuilder statement, IEndQuery endClosure)
        {
            this.statement = statement;
            end = new EndCommonTableExpression(statement, endClosure);
        }

        public IEndCommonTableExpression With()
        {
            statement.Append((ICommonTableExpressionEnd<IEndCommonTableExpression> input) => input.With());
            return end;
        }
    }
}
