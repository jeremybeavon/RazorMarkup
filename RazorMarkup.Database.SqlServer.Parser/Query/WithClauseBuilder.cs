using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class WithClauseBuilder
    {
        public static TOperand BuildCommonTableExpressions<TOperand, TEndCommonTableExpression>(
            TOperand statement,
            IWithClause<ICommonTableExpressionEnd<TEndCommonTableExpression>> withClause,
            WithCtesAndXmlNamespaces withCtesAndXmlNamespaces)
            where TEndCommonTableExpression : TOperand, IEndCommonTableExpression<TEndCommonTableExpression>
        {
            if (withCtesAndXmlNamespaces == null || withCtesAndXmlNamespaces.CommonTableExpressions.Count == 0)
            {
                return statement;
            }

            CommonTableExpression expression = withCtesAndXmlNamespaces.CommonTableExpressions[0];
            TEndCommonTableExpression expressionEnd = BuildCommonTableExpression(withClause, expression);
            foreach (CommonTableExpression cte in withCtesAndXmlNamespaces.CommonTableExpressions.Skip(1))
            {
                expressionEnd = BuildCommonTableExpression(expressionEnd.And(), cte);
            }

            return expressionEnd;
        }

        private static TEndCommonTableExpression BuildCommonTableExpression<TEndCommonTableExpression>(
            IWithClause<ICommonTableExpressionEnd<TEndCommonTableExpression>> withClause,
            CommonTableExpression expression)
        {
            TableAlias tableAlias = new TableAlias(expression.ExpressionName.Value);
            ColumnAlias[] columnNames = expression.Columns.Select(name => new ColumnAlias(name.Value)).ToArray();
            ICommonTableExpression<ICommonTableExpressionEnd<TEndCommonTableExpression>> cte = withClause.With(tableAlias, columnNames);
            return expression.QueryExpression.AcceptWithResult(cte.As()).End().With();
        }
    }
}
