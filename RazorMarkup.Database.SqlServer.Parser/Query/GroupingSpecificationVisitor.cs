using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class GroupingSpecificationVisitor : AbstractSqlVisitor<ICommonGroupBy>
    {
        private ICommonGroupBy groupBy;

        public GroupingSpecificationVisitor(ICommonGroupBy groupBy)
        {
            this.groupBy = groupBy;
        }

        public override void ExplicitVisit(CompositeGroupingSpecification node)
        {
            Result = groupBy.Group(node.Items);
        }

        public override void ExplicitVisit(CubeGroupingSpecification node)
        {
            Result = groupBy.Cube(node.Arguments);
        }

        public override void ExplicitVisit(ExpressionGroupingSpecification node)
        {
            Result = groupBy.GroupBy(node.Expression.ToExpression<object>());
        }

        public override void ExplicitVisit(GrandTotalGroupingSpecification node)
        {
            Result = groupBy.GrandTotal();
        }

        public override void ExplicitVisit(GroupingSetsGroupingSpecification node)
        {
            Result = groupBy.GroupingSet(node.Sets);
        }

        public override void ExplicitVisit(RollupGroupingSpecification node)
        {
            Result = groupBy.Rollup(node.Arguments);
        }
    }
}
