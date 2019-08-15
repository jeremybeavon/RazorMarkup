using System;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class MergeStatement : AbstractStatement<MergeStatementBuilder>, IMergeStatement
    {
        public MergeStatement()
            : base(new MergeStatementBuilder(new ExpressionBuilder()))
        {
        }

        public IMergeTopPercent Top(Expression<Func<Integer>> count)
        {
            Statement.Top = new ExpressionBuilder<Integer>(count);
            //Statement.Append((I))
            throw new NotImplementedException();
        }

        public ICommonTableExpression<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>> With(
            TableAlias tableName,
            params ColumnAlias[] columnNames)
        {
            Statement.Append((IMergeStatement input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            WithClauseBuilder withClause = new WithClauseBuilder(ExpressionBuilder, tableName, columnNames);
            Statement.WithClause = withClause;
            return new CommonTableExpression<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>>(
                withClause,
                new CommonTableExpressionEndMerge(Statement));
        }
    }
}
