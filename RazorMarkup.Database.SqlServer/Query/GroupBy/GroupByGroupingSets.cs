﻿using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSets<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSets<TEndType>
    {
        private readonly IGroupByAnd<TEndType> groupingSetClosure;

        public GroupByGroupingSets(GroupFunctionQueryBuilder statement, IGroupByAnd<TEndType> groupingSetClosure)
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
            return groupingSetClosure;
        }
    }
}
