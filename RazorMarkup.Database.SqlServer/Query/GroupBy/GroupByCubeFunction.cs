using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByCubeFunction<TEndCubeType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByCubeFunction<TEndCubeType>
    {
        private readonly TEndCubeType cubeClosure;

        public GroupByCubeFunction(GroupFunctionQueryBuilder statement, TEndCubeType cubeClosure)
            : base(statement)
        {
            this.cubeClosure = cubeClosure;
        }

        public IGroupByGroup<IGroupByCube<TEndCubeType>> Group(Expression<Func<object>> groupingExpression)
        {
            Statement.Append((IGroupByCubeFunction<TEndCubeType> input) => input.Group(null), groupingExpression);
            GroupByGroupQueryBuilder queryBuilder = new GroupByGroupQueryBuilder(ExpressionBuilder);
            Statement.Groupings.Add(queryBuilder);
            queryBuilder.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            GroupByCube<TEndCubeType> groupClosure = new GroupByCube<TEndCubeType>(Statement, cubeClosure);
            return new GroupByGroup<IGroupByCube<TEndCubeType>>(queryBuilder, groupClosure);
        }
    }
}
