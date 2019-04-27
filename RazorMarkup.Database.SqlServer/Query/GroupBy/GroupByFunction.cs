using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByFunction<TEndType> : AbstractQueryStatement<GroupByClauseBuilder, TEndType>,
        IGroupByFunction<TEndType>, IClauseStart<IGroupByFunction<TEndType>>
    {
        public GroupByFunction(GroupByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public GroupByFunction(ExpressionBuilder expressionBuilder, TEndType endClosure)
            : base(new GroupByClauseBuilder(expressionBuilder), endClosure)
        {
        }

        public IGroupByCube<IGroupByAnd<TEndType>> Cube(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.Cube(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "CUBE");
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByAnd<TEndType> cubeClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByCube<IGroupByAnd<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByCubeFunction<IGroupByAnd<TEndType>> Cube()
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.Cube());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "CUBE");
            Statement.Groupings.Add(queryBuilder);
            GroupByAnd<TEndType> cubeClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByCubeFunction<IGroupByAnd<TEndType>>(queryBuilder, cubeClosure);
        }

        public IGroupByRollup<IGroupByAnd<TEndType>> Rollup(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.Rollup(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByAnd<TEndType> rollupClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByRollup<IGroupByAnd<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByRollupFunction<IGroupByAnd<TEndType>> Rollup()
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.Rollup());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "ROLLUP");
            Statement.Groupings.Add(queryBuilder);
            GroupByAnd<TEndType> rollupClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByRollupFunction<IGroupByAnd<TEndType>>(queryBuilder, rollupClosure);
        }

        public IGroupByGroupingSets<TEndType> GroupingSets(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.GroupingSets(null), groupingExpression);
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "GROUPING SETS");
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByAnd<TEndType> groupingSetClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByGroupingSets<TEndType>(queryBuilder, groupingSetClosure);
        }

        public IGroupByGroupingSetsFunction<TEndType> GroupingSets()
        {
            Statement.Append((IGroupByFunction<TEndType> input) => input.GroupingSets());
            GroupFunctionQueryBuilder queryBuilder = new GroupFunctionQueryBuilder(ExpressionBuilder, "GROUPING SETS");
            Statement.Groupings.Add(queryBuilder);
            GroupByAnd<TEndType> groupingSetClosure = new GroupByAnd<TEndType>(Statement, EndClosure);
            return new GroupByGroupingSetsFunction<TEndType>(queryBuilder, groupingSetClosure);
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
