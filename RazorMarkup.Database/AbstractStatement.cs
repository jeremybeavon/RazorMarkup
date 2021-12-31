using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public abstract class AbstractStatement<TStatementBuilder> : ISqlString
        where TStatementBuilder : AbstractStatementBuilder
    {
        protected AbstractStatement(TStatementBuilder statement)
        {
            Statement = statement;
        }

        protected TStatementBuilder Statement { get; private set; }

        protected ExpressionBuilder ExpressionBuilder => Statement.ExpressionBuilder;

        public Expression ToExpression()
        {
            return Statement.ToExpression();
        }

        public string ToSqlString()
        {
            return Statement.ToSqlString();
        }
    }
}
