using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByGroupingSetFunction<TEndType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByGroupingSetFunction<TEndType>
    {
        private IGroupByAnd<TEndType> groupingSetClosure;

        public GroupByGroupingSetFunction(GroupFunctionQueryBuilder statement, IGroupByAnd<TEndType> groupingSetClosure)
            : base(statement)
        {
            this.groupingSetClosure = groupingSetClosure;
        }

        public IGroupByCube<IGroupByGroupingSet<TEndType>> Cube(Expression<Func<object>> groupingExpression)
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Cube(null), groupingExpression);
            IGroupByGroupingSet<TEndType> cubeClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByCube<IGroupByGroupingSet<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByCubeFunction<IGroupByGroupingSet<TEndType>> Cube()
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Cube());
            IGroupByGroupingSet<TEndType> cubeClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByCubeFunction<IGroupByGroupingSet<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByRollup<IGroupByGroupingSet<TEndType>> Rollup(Expression<Func<object>> groupingExpression)
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Rollup(null), groupingExpression);
            IGroupByGroupingSet<TEndType> rollupClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
            return new GroupByRollup<IGroupByGroupingSet<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByRollupFunction<IGroupByGroupingSet<TEndType>> Rollup()
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByGroupingSetFunction<TEndType> input) => input.Rollup());
            IGroupByGroupingSet<TEndType> rollupClosure = new GroupByGroupingSet<TEndType>(Statement, groupingSetClosure);
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
