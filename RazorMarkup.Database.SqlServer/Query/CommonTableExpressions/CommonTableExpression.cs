using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpression : AbstractCommonTableExpression, ICommonTableExpression,
        IClauseStart<ICommonTableExpression>
    {
        public CommonTableExpression(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }

        public CommonTableExpression(ExpressionBuilder expressionBuilder, TableAlias tableName, ColumnAlias[] columnNames, IEndQuery endClosure)
            : base(new WithClauseBuilder(expressionBuilder, tableName, columnNames), endClosure)
        {
        }

        public IQueryOperand<ICommonTableExpressionEnd> As()
        {
            Statement.Append((ICommonTableExpression input) => input.As());
            return new CommonTableExpressionQuery(Statement, EndClosure);
        }

        public ICommonTableExpression AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
