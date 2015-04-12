using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyFromClause<TEndType> : IEndFromClause<TEndType>
    {
        private readonly ISelectClauseWithFrom<TEndType> fromClause;

        public EmptyFromClause(ISelectClauseWithFrom<TEndType> fromClause)
        {
            this.fromClause = fromClause;
        }

        public TEndType End()
        {
            return fromClause.End();
        }

        public IEndWhereClause<TEndType> Where(Expression<Func<bool>> searchCondition)
        {
            throw new NotSupportedException();
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            throw new NotSupportedException();
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            throw new NotSupportedException();
        }

        public IQueryOperand<TEndType> Union()
        {
            throw new NotSupportedException();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            throw new NotSupportedException();
        }

        public IQueryOperand<TEndType> Except()
        {
            throw new NotSupportedException();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            throw new NotSupportedException();
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            throw new NotSupportedException();
        }

        public IForBrowseOrXml<TEndType> For()
        {
            throw new NotSupportedException();
        }
    }
}
