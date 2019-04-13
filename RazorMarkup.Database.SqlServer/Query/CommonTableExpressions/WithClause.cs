using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class WithClause<TEndType> : AbstractCommonTableExpression<TEndType>, IWithClause<TEndType>
    {
        public WithClause(WithClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ICommonTableExpression<TEndType> With(TableAlias tableName, params ColumnAlias[] columnNames)
        {
            Statement.CommonTableExpressions.Add(new CommonTableExpressionBuilder(ExpressionBuilder, tableName, columnNames));
            Statement.Append((IWithClause<TEndType> input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            return new CommonTableExpression<TEndType>(Statement, EndClosure);
        }
    }
}
