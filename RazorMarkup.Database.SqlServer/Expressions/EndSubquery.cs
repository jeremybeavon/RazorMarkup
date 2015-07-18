using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    internal sealed class EndSubquery : IEndSubquery
    {
        private readonly SubqueryExpressionBuilder statement;

        public EndSubquery(SubqueryExpressionBuilder statement)
        {
            this.statement = statement;
        }

        public ISqlString Subquery()
        {
            statement.Append((IEndSubquery input) => input.Subquery());
            return statement;
        }
    }
}
