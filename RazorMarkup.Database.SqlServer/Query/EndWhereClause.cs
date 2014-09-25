using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndWhereClause<TEndType> : AbstractQueryStatement<WhereClauseBuilder, TEndType>,
        IEndWhereClause<TEndType>, IClauseStart<IEndWhereClause<TEndType>>
    {
        public EndWhereClause(Expression<Func<bool>> searchCondition, TEndType endClosure)
            : base(new WhereClauseBuilder(searchCondition), endClosure)
        {
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            return new GroupByAnd<TEndType>(groupingExpression, EndClosure).AsNextClause(Statement);
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            return new GroupByFunction<TEndType>(EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Union()
        {
            return new QueryOperand<TEndType>(QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return new QueryOperand<TEndType>(QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            return new QueryOperand<TEndType>(QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return new QueryOperand<TEndType>(QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByWithCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return new OrderByWithCollate<TEndType>(expression, EndClosure).AsNextClause(Statement);
        }

        public IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression)
        {
            return new OffsetRow<TEndType>(expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return new ForBrowseOrXml<TEndType>(EndClosure).AsNextClause(Statement);
        }

        public IEndWhereClause<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
