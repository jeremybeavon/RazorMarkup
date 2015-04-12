using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal class ClauseBuilder : AbstractStatementBuilder
    {
        public ClauseBuilder(Expression initialExpression)
            : base(initialExpression)
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

        public override Expression ToExpression()
        {
            return NextClause == null ? Expression : NextClause.ToExpression();
        }
    }
}
