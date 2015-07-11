using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal class GroupByCube<TEndCubeType> : AbstractStatement<GroupFunctionQueryBuilder>, IGroupByCube<TEndCubeType>, 
        IClosure<IGroupByCube<TEndCubeType>>
    {
        private readonly IClosure<TEndCubeType> cubeClosure;

        public GroupByCube(GroupFunctionQueryBuilder statement, IClosure<TEndCubeType> cubeClosure)
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
            return cubeClosure.End(Statement.Expression);
        }

        public IGroupByCube<TEndCubeType> End(Expression expression)
        {
            Statement.UpdateExpression(expression);
            return this;
        }
    }
}
