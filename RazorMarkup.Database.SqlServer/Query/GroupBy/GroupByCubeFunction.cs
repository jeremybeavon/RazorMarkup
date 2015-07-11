using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByCubeFunction<TEndCubeType> : AbstractStatement<GroupFunctionQueryBuilder>,
        IGroupByCubeFunction<TEndCubeType>
    {
        private readonly IClosure<TEndCubeType> cubeClosure;

        public GroupByCubeFunction(GroupFunctionQueryBuilder statement, IClosure<TEndCubeType> cubeClosure)
            : base(statement)
        {
            this.cubeClosure = cubeClosure;
        }

        public IGroupByGroup<IGroupByCube<TEndCubeType>> Group(Expression<Func<object>> groupingExpression)
        {
            GroupByGroupQueryBuilder queryBuilder = new GroupByGroupQueryBuilder();
            Statement.Groupings.Add(queryBuilder);
            Statement.Append((IGroupByCubeFunction<TEndCubeType> input) => input.Group(null), groupingExpression);
            IGroupByCube<TEndCubeType> groupClosure = new GroupByCube<TEndCubeType>(Statement, cubeClosure);
            return new GroupByGroup<IGroupByCube<TEndCubeType>>(queryBuilder, groupClosure);
        }
    }
}
