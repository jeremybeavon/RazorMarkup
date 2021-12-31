using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class MergeStatement : MergeClause, IMergeStatement
    {
        public MergeStatement()
            : base(new MergeStatementBuilder(new ExpressionBuilder()))
        {
        }

        public ICommonTableExpression<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>> With(
            TableAlias tableName,
            params ColumnAlias[] columnNames)
        {
            Statement.Append((IMergeStatement input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            WithClauseBuilder withClause = new(ExpressionBuilder, tableName, columnNames);
            Statement.WithClause = withClause;
            return new CommonTableExpression<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>>(
                withClause,
                new CommonTableExpressionEndMerge(Statement));
        }
    }
}
