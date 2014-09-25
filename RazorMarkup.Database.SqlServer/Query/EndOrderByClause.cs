using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

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
            return new OffsetRow<TEndType>(expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return new ForBrowseOrXml<TEndType>(EndClosure).AsNextClause(Statement);
        }
    }
}
