using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal sealed class GroupByCube<TEndCubeType> : AbstractGroupBy
    {
        private readonly IGroupByCube<TEndCubeType> groupByCube;

        public GroupByCube(IGroupByCube<TEndCubeType> groupByCube)
            : base(groupByCube)
        {
            this.groupByCube = groupByCube;
        }

        public override ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            return new GroupByCube<TEndCubeType>(groupByCube.And(expression));
        }

        public override ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            ICommonGroupBy end = arguments.AcceptWithResult(new GroupByCubeFunction<TEndCubeType>(groupByCube.And()));
            return new GroupByCube<TEndCubeType>(end.End<IGroupByGroup<IGroupByCube<TEndCubeType>>>().EndGroup());
        }
    }
}
