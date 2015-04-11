using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class SelectStatementVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(SelectStatement node)
        {
            IQueryOperand<IEndQuery> operand;
            if (node.WithCtesAndXmlNamespaces != null && node.WithCtesAndXmlNamespaces.CommonTableExpressions.Count != 0)
            {
                CommonTableExpression expression = node.WithCtesAndXmlNamespaces.CommonTableExpressions[0];
                IEndCommonTableExpression expressionEnd = BuildCommonTableExpression(Sql.Query(), expression);
                foreach (CommonTableExpression cte in node.WithCtesAndXmlNamespaces.CommonTableExpressions.Skip(1))
                {
                    expressionEnd = BuildCommonTableExpression(expressionEnd.And(), cte);
                }

                operand = expressionEnd;
            }
            else
            {
                operand = Sql.Query();
            }

            Result = operand.Select(node);
        }

        private static IEndCommonTableExpression BuildCommonTableExpression(IWithClause withClause, CommonTableExpression expression)
        {
            TableAlias tableAlias = new TableAlias(expression.ExpressionName.Value);
            ColumnAlias[] columnNames = expression.Columns.Select(name => new ColumnAlias(name.Value)).ToArray();
            return withClause.With(tableAlias, columnNames).As(expression.QueryExpression);
        }
    }
}
