using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class FromClause<TEndType> : TableSource<TEndType>, IFromClause<TEndType>, IClauseStart<IFromClause<TEndType>>
    {
        public FromClause(ExpressionBuilder expressionBuilder, TEndType endClosure)
            : base(new FromClauseBuilder(expressionBuilder), endClosure)
        {
        }

        public IFromClause<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
