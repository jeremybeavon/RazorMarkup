using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Query.Select;
using System.Linq;

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

        public IQueryOperand<IQueryGroupEnd<IEndQuery>> BeginQueryGroup()
        {
            Append((IQueryStatements input) => input.BeginQueryGroup());
            return new QueryOperatorGroupEnd<IEndQuery>(ExpressionBuilder, new EndQuery(this)).AsNextClause(this).AsOperand();
        }

        public ICommonTableExpression<ICommonTableExpressionEnd<IEndCommonTableExpression>> With(TableAlias tableName, params ColumnAlias[] columnNames)
        {
            Append((IQueryStatements input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            WithClauseBuilder statement = new(ExpressionBuilder, tableName, columnNames);
            return new CommonTableExpression<ICommonTableExpressionEnd<IEndCommonTableExpression>>(
                statement,
                new CommonTableExpressionEnd(statement, new EndQuery(this))).AsNextClause(this);
        }
    }
}
