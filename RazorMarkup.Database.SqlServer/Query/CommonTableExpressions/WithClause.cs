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
            Statement.CommonTableExpressions.Add(new CommonTableExpressionBuilder(tableName, columnNames));
            return new CommonTableExpression(Statement, EndClosure);
        }
    }
}
