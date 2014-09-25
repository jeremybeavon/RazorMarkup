using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndQueryOperatorGroup<TEndType> : AbstractQueryStatement<QueryOperatorGroupBuilder, TEndType>,
        IEndQueryOperatorGroup<TEndType>
    {
        public EndQueryOperatorGroup(QueryOperatorGroupBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
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
    }
}
