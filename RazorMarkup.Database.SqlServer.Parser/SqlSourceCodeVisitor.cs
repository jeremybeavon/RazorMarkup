using System;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(TSqlBatch node)
        {
            node.AcceptChildren(this);
        }

        public override void ExplicitVisit(TSqlScript node)
        {
            node.AcceptChildren(this);
        }

        public override void ExplicitVisit(SelectStatement node)
        {
            IQueryOperand<IEndQuery> operand;
            object result;
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

            result = new QueryOperandVisitor<IEndQuery>(operand, node.QueryExpression).Result;
            /*if (node.OptimizerHints.Count != 0)
            {
                //IOptionClause<IEndQuery> optionClause = 
            }*/

            Result = ((IHasEnd<IEndQuery>)result).End().Query();
        }

        private static IEndCommonTableExpression BuildCommonTableExpression(
            IWithClause withClause,
            CommonTableExpression expression)
        {
            TableAlias tableAlias = new TableAlias(expression.ExpressionName.Value);
            ColumnAlias[] columnNames = expression.Columns.Select(name => new ColumnAlias(name.Value)).ToArray();
            IQueryOperand<ICommonTableExpressionEnd> cteOperand = Sql.Query().With(tableAlias, columnNames).As();
            object result = new QueryOperandVisitor<ICommonTableExpressionEnd>(cteOperand, expression.QueryExpression).Result;
            return ((IHasEnd<ICommonTableExpressionEnd>)result).End().With();
        }

        private static TableName GetTableName(SchemaObjectName name)
        {
            return new TableName(name.BaseIdentifier.Value);
        }
    }
}
