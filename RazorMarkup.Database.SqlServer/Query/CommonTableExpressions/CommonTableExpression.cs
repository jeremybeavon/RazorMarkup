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

        public CommonTableExpression(TableAlias tableName, ColumnAlias[] columnNames, Expression expression, IEndQuery endClosure)
            : base(new WithClauseBuilder(tableName, columnNames, expression), endClosure)
        {
        }

        public IQueryOperand<ICommonTableExpressionEnd> As()
        {
            return new CommonTableExpressionQuery(Statement, EndClosure);
        }

        public ICommonTableExpression AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
