using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByRollup<TEndRollupType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByRollup<TEndRollupType>
    {
        private readonly TEndRollupType rollupClosure;

        public GroupByRollup(GroupFunctionQueryBuilder statement, TEndRollupType rollupClosure)
            : base(statement)
        {
            this.rollupClosure = rollupClosure;
        }
        
        public IGroupByRollup<TEndRollupType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            return this;
        }

        public IGroupByRollupFunction<TEndRollupType> And()
        {
            return new GroupByRollupFunction<TEndRollupType>(Statement, rollupClosure);
        }

        public TEndRollupType EndRollup()
        {
            return rollupClosure;
        }
    }
}
