﻿using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByRollup<TEndRollupType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByRollup<TEndRollupType>, IClosure<IGroupByRollup<TEndRollupType>>
    {
        private readonly IClosure<TEndRollupType> rollupClosure;

        public GroupByRollup(GroupFunctionQueryBuilder statement, IClosure<TEndRollupType> rollupClosure)
            : base(statement)
        {
            this.rollupClosure = rollupClosure;
        }
       
        public IGroupByRollup<TEndRollupType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByRollup<TEndRollupType> input) => input.And(null), groupingExpression);
            return this;
        }

        public IGroupByRollupFunction<TEndRollupType> And()
        {
            Statement.Append((IGroupByRollup<TEndRollupType> input) => input.And());
            return new GroupByRollupFunction<TEndRollupType>(Statement, rollupClosure);
        }

        public TEndRollupType EndRollup()
        {
            Statement.Append((IGroupByRollup<TEndRollupType> input) => input.EndRollup());
            return rollupClosure.End(Statement.Expression);
        }

        public IGroupByRollup<TEndRollupType> End(Expression expression)
        {
            Statement.UpdateExpression(expression);
            return this;
        }
    }
}
