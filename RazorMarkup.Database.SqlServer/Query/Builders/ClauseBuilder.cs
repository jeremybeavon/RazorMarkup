using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal class ClauseBuilder : AbstractStatementBuilder
    {
        public ClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public AbstractStatementBuilder NextClause { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (NextClause != null)
            {
                NextClause.ToSqlString(sqlBuilder);
            }
        }
    }
}
