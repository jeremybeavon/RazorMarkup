using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSet<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSet<TEndType>, IClosure<IGroupByGroupingSet<TEndType>>
    {
        private readonly IClosure<IGroupByAnd<TEndType>> groupingSetClosure;

        public GroupByGroupingSet(GroupFunctionQueryBuilder statement, IClosure<IGroupByAnd<TEndType>> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByGroupingSet<TEndType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByGroupingSet<TEndType> input) => input.And(null), groupingExpression);
            return this;
        }

        public IGroupByGroupingSetFunction<TEndType> And()
        {
            throw new NotImplementedException();
        }

        public IGroupByAnd<TEndType> EndGroupingSet()
        {
            Statement.Append((IGroupByGroupingSet<TEndType> input) => input.EndGroupingSet());
            return groupingSetClosure.End(Expression);
        }

        public IGroupByGroupingSet<TEndType> End(Expression expression)
        {
            Statement.UpdateExpression(expression);
            return this;
        }
    }
}
