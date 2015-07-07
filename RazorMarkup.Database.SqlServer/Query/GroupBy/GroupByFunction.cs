using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByFunction<TEndType> : AbstractQueryStatement<GroupByClauseBuilder, TEndType>,
        IGroupByFunction<TEndType>, IClauseStart<IGroupByFunction<TEndType>>
    {
        public GroupByFunction(GroupByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public GroupByFunction(Expression initialExpression, TEndType endClosure)
            : base(new GroupByClauseBuilder(initialExpression), endClosure)
        {
        }

        public IGroupByCube<IGroupByAnd<TEndType>> Cube(Expression<Func<object>> groupingExpression)
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.Cube(null), groupingExpression);
            IGroupByAnd<TEndType> cubeClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByCube<IGroupByAnd<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByCubeFunction<IGroupByAnd<TEndType>> Cube()
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("CUBE");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.Cube());
            IGroupByAnd<TEndType> cubeClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByCubeFunction<IGroupByAnd<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByRollup<IGroupByAnd<TEndType>> Rollup(Expression<Func<object>> groupingExpression)
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.Rollup(null), groupingExpression);
            IGroupByAnd<TEndType> rollupClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByRollup<IGroupByAnd<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByRollupFunction<IGroupByAnd<TEndType>> Rollup()
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.Rollup());
            IGroupByAnd<TEndType> rollupClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByRollupFunction<IGroupByAnd<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByGroupingSet<TEndType> GroupingSet(Expression<Func<object>> groupingExpression)
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("GROUPING SET");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.GroupingSet(null), groupingExpression);
            IGroupByAnd<TEndType> groupingSetClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByGroupingSet<TEndType>(queryBuilder, groupingSetClosure);
        }

        public IGroupByGroupingSetFunction<TEndType> GroupingSet()
        {
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder("GROUPING SET");
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.GroupingSet());
            IGroupByAnd<TEndType> groupingSetClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByGroupingSetFunction<TEndType>(queryBuilder, groupingSetClosure);
        }

        public IGroupByGroup<IGroupByAnd<TEndType>> Group(Expression<Func<object>> groupingExpression)
        {
            GroupByGroupQueryBuilder queryBuilder = new GroupByGroupQueryBuilder();
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByFunction<TEndType> input) => input.Group(null), groupingExpression);
            IGroupByAnd<TEndType> closure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByGroup<IGroupByAnd<TEndType>>(queryBuilder, closure);
        }

        public IGroupByAnd<TEndType> GrandTotal()
        {
            Statement.Groupings.Add(new RawStatementBuilder("()"));
            Statement.Append((IGroupByFunction<TEndType> input) => input.GrandTotal());
            return new GroupByAnd<TEndType>(Statement, EndClosure);
        }

        public IGroupByFunction<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
