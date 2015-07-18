using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class WithClause : AbstractCommonTableExpression, IWithClause
    {
        public WithClause(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }

        public ICommonTableExpression With(TableAlias tableName, params ColumnAlias[] columnNames)
        {
            Statement.CommonTableExpressions.Add(new CommonTableExpressionBuilder(ExpressionBuilder, tableName, columnNames));
            Statement.Append((IWithClause input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            return new CommonTableExpression(Statement, EndClosure);
        }
    }
}
