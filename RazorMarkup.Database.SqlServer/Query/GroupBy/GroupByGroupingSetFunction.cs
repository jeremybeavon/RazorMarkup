using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSetFunction<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSetFunction<TEndType>
    {
        private IClosure<IGroupByAnd<TEndType>> groupingSetClosure;

        public GroupByGroupingSetFunction(GroupFunctionQueryBuilder statement, IClosure<IGroupByAnd<TEndType>> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByCube<IGroupByGroupingSet<TEndType>> Cube(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Cube(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSet<TEndType> cubeClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByCube<IGroupByGroupingSet<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByCubeFunction<IGroupByGroupingSet<TEndType>> Cube()
        {
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Cube());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSet<TEndType> cubeClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByCubeFunction<IGroupByGroupingSet<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByRollup<IGroupByGroupingSet<TEndType>> Rollup(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Rollup(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSet<TEndType> rollupClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByRollup<IGroupByGroupingSet<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByRollupFunction<IGroupByGroupingSet<TEndType>> Rollup()
        {
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Rollup());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP", Expression);
            Statement.Groupings.Add(queryBuilder);
            GroupByGroupingSet<TEndType> rollupClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByRollupFunction<IGroupByGroupingSet<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByGroup<IGroupByGroupingSet<TEndType>> Group(Expression<Func<object>> groupingExpression)
        {
            GroupByGroupQueryBuilder queryBuilder = new GroupByGroupQueryBuilder();
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Group(null), groupingExpression);
            IGroupByGroupingSet<TEndType> closure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByGroup<IGroupByGroupingSet<TEndType>>(queryBuilder, closure);
        }

        public IGroupByGroupingSet<TEndType> GrandTotal()
        {
            Statement.Groupings.Add(new RawStatementBuilder("()"));
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.GrandTotal());
            return new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
        }
    }
}
