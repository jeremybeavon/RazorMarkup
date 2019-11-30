using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Merge;
using RazorMarkup.Database.SqlServer.Parser.Query;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(MergeStatement node)
        {
            IMergeStatement mergeStatement = Sql.Merge();
            IMergeClause mergeClause =
                WithClauseBuilder.BuildCommonTableExpressions<IMergeClause, IEndMergeCommonTableExpression>(
                    mergeStatement,
                    mergeStatement,
                    node.WithCtesAndXmlNamespaces);
            IMergeTargetTable targetTable = GetMergeTargetTable(node.MergeSpecification, mergeClause);
            //IMergeWithHint mergeWithHint = targetTable.Table(new TableName(node.MergeSpecification.Target))
        }

        private static IMergeTargetTable GetMergeTargetTable(MergeSpecification node, IMergeClause mergeClause)
        {
            if (node.TopRowFilter == null || node.TopRowFilter.Expression == null)
            {
                return mergeClause;
            }

            IMergeTopPercent mergeTopPercent = mergeClause.Top(
                SqlExpressionVisitor.ToExpression<Integer>(node.TopRowFilter.Expression));
            return node.TopRowFilter.Percent ? mergeTopPercent.Percent() : mergeTopPercent;
        }
    }
}
