using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

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
            return this;
        }

        public IGroupByCubeFunction<TEndCubeType> And()
        {
            return new GroupByCubeFunction<TEndCubeType>(Statement, cubeClosure);
        }

        public TEndCubeType EndCube()
        {
            return cubeClosure;
        }
    }
}
