using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSetsFunction<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSetsFunction<TEndType>
    {
        private IClosure<IGroupByAnd<TEndType>> groupingSetClosure;

        public GroupByGroupingSetsFunction(GroupFunctionQueryBuilder statement, IClosure<IGroupByAnd<TEndType>> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByCube<IGroupByGroupingSets<TEndType>> Cube(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByGroupingSetsFunction<TEndType> input) => input.Cube(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE", Expression);
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByGroupingSets<TEndType> cubeClosure = new GroupByGroupingSets<TEndType>(Statement, groupingSetClosure);
            return new GroupByCube<IGroupByGroupingSets<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByCubeFunction<IGroupByGroupingSets<TEndType>> Cube()
        {
            Statement.Append((IGroupByGroupingSetsFunction<TEndType> input) => input.Cube());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSets<TEndType> cubeClosure = new GroupByGroupingSets<TEndType>(Statement, groupingSetClosure);
            return new GroupByCubeFunction<IGroupByGroupingSets<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByRollup<IGroupByGroupingSets<TEndType>> Rollup(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByGroupingSetsFunction<TEndType> input) => input.Rollup(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP", Expression);
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByGroupingSets<TEndType> rollupClosure = new GroupByGroupingSets<TEndType>(Statement, groupingSetClosure);
            return new GroupByRollup<IGroupByGroupingSets<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByRollupFunction<IGroupByGroupingSets<TEndType>> Rollup()
        {
            Statement.Append((IGroupByGroupingSetsFunction<TEndType> input) => input.Rollup());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSets<TEndType> rollupClosure = new GroupByGroupingSets<TEndType>(Statement, groupingSetClosure);
            return new GroupByRollupFunction<IGroupByGroupingSets<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByGroupingSets<TEndType> GrandTotal()
        {
            Statement.Groupings.Add(new RawStatementBuilder("()"));
            Statement.Append((IGroupByGroupingSetsFunction<TEndType> input) => input.GrandTotal());
            return new GroupByGroupingSets<TEndType>(Statement, groupingSetClosure);
        }
    }
}
