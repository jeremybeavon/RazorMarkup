using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSets<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSets<TEndType>, IClosure<IGroupByGroupingSets<TEndType>>
    {
        private readonly IClosure<IGroupByAnd<TEndType>> groupingSetClosure;

        public GroupByGroupingSets(GroupFunctionQueryBuilder statement, IClosure<IGroupByAnd<TEndType>> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByGroupingSets<TEndType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByGroupingSets<TEndType> input) => input.And(null), groupingExpression);
            return this;
        }

        public IGroupByGroupingSetsFunction<TEndType> And()
        {
            throw new NotImplementedException();
        }

        public IGroupByAnd<TEndType> EndGroupingSets()
        {
            Statement.Append((IGroupByGroupingSets<TEndType> input) => input.EndGroupingSets());
            return groupingSetClosure.End(Expression);
        }

        public IGroupByGroupingSets<TEndType> End(Expression expression)
        {
            Statement.UpdateExpression(expression);
            return this;
        }
    }
}
