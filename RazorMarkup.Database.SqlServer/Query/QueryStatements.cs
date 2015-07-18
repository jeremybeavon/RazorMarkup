using System;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class QueryStatements : ClauseBuilder, IQueryStatements
    {
        public QueryStatements()
            : base(new ExpressionBuilder())
        {
            Initialize(() => Sql.Query());
        }

        public ISelectClauseWithDistinct<IEndQuery> Select()
        {
            Append((IQueryStatements input) => input.Select());
            return new SelectClauseWithDistinct<IEndQuery>(ExpressionBuilder, new EndQuery(this)).AsNextClause(this);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<IEndQuery>> BeginOperatorGroup()
        {
            Append((IQueryStatements input) => input.BeginOperatorGroup());
            return new QueryOperatorGroupEnd<IEndQuery>(ExpressionBuilder, new EndQuery(this)).AsNextClause(this).AsOperand();
        }

        public ICommonTableExpression With(TableAlias tableName, params ColumnAlias[] columnNames)
        {
            Append((IQueryStatements input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            return new CommonTableExpression(ExpressionBuilder, tableName, columnNames, new EndQuery(this)).AsNextClause(this);
        }
    }
}
