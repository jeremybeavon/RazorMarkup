using System;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal class ClauseBuilder : AbstractStatementBuilder
    {
        private AbstractStatementBuilder nextClause;

        public ClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public AbstractStatementBuilder NextClause
        {
            get => nextClause;
            set
            {
                if (nextClause == null)
                {
                    nextClause = value;
                }
                else
                {
                    throw new InvalidOperationException("NextClause cannot be set more than once.");
                }
            }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (NextClause != null)
            {
                NextClause.ToSqlString(sqlBuilder);
            }
        }
    }
}
