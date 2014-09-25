using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpressionEnd : ICommonTableExpressionEnd
    {
        private readonly IEndCommonTableExpression end;

        public CommonTableExpressionEnd(WithClauseBuilder statement, IEndQuery endClosure)
        {
            end = new EndCommonTableExpression(statement, endClosure);
        }

        public IEndCommonTableExpression With()
        {
            return end;
        }
    }
}
