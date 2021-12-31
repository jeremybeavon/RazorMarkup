using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndOrderByClause<TEndType> : AbstractQueryStatement<OrderByClauseBuilder, TEndType>,
        IEndOrderByClause<TEndType>
    {
        public EndOrderByClause(OrderByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression)
        {
            Statement.Append((IEndOrderByClause<TEndType> input) => input.Offset(null), expression);
            return new OffsetRow<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            Statement.Append((IEndOrderByClause<TEndType> input) => input.For());
            return new ForBrowseOrXml<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
