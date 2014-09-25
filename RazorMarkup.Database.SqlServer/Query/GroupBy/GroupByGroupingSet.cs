using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSet<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSet<TEndType>
    {
        private readonly IGroupByAnd<TEndType> groupingSetClosure;

        public GroupByGroupingSet(GroupFunctionQueryBuilder statement, IGroupByAnd<TEndType> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByGroupingSet<TEndType> And(Expression<Func<object>> groupingExpression)
        {
            throw new NotImplementedException();
        }

        public IGroupByGroupingSetFunction<TEndType> And()
        {
            throw new NotImplementedException();
        }

        public IGroupByAnd<TEndType> EndGroupingSet()
        {
            return groupingSetClosure;
        }
    }
}
