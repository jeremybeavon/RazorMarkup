using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByCube<TEndCubeType> : AbstractStatement<GroupFunctionQueryBuilder>, IGroupByCube<TEndCubeType>
    {
        private readonly TEndCubeType cubeClosure;

        public GroupByCube(GroupFunctionQueryBuilder statement, TEndCubeType cubeClosure)
            : base(statement)
        {
            this.cubeClosure = cubeClosure;
        }
        
        public IGroupByCube<TEndCubeType> And(Expression<Func<object>> groupingExpression)
        {
            Statement.Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
            Statement.Append((IGroupByCube<TEndCubeType> input) => input.And(null), groupingExpression);
            return this;
        }

        public IGroupByCubeFunction<TEndCubeType> And()
        {
            Statement.Append((IGroupByCube<TEndCubeType> input) => input.And());
            return new GroupByCubeFunction<TEndCubeType>(Statement, cubeClosure);
        }

        public TEndCubeType EndCube()
        {
            Statement.Append((IGroupByCube<TEndCubeType> input) => input.EndCube());
            return cubeClosure;
        }
    }
}
