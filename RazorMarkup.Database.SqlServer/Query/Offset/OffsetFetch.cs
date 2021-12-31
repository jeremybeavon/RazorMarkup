using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    internal class OffsetFetch<TEndType> : EndOffsetClause<TEndType>, IOffsetFetch<TEndType>
    {
        public OffsetFetch(OffsetClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IOffsetFetchRow<TEndType> FetchFirst(Expression<Func<Integer>> expression)
        {
            Statement.FetchExpression = new ExpressionBuilder<Integer>(expression);
            Statement.IsFetchFirst = true;
            Statement.Append((IOffsetFetch<TEndType> input) => input.FetchFirst(null), expression);
            return new OffsetFetchRow<TEndType>(Statement, EndClosure);
        }

        public IOffsetFetchRow<TEndType> FetchNext(Expression<Func<Integer>> expression)
        {
            Statement.FetchExpression = new ExpressionBuilder<Integer>(expression);
            Statement.IsFetchFirst = false;
            Statement.Append((IOffsetFetch<TEndType> input) => input.FetchNext(null), expression);
            return new OffsetFetchRow<TEndType>(Statement, EndClosure);
        }
    }
}
