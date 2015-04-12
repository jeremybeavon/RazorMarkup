using System;
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

        protected Expression Expression
        {
            get { return Statement.Expression; }
        }

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
