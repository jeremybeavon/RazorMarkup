using System;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Common;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class QueryStatements : ClauseBuilder, IQueryStatements, ISqlString
    {
        public QueryStatements()
        {
            Initialize(() => Sql.Query());
        }

        public ISelectClauseWithDistinct<IEndQuery> Select()
        {
            Append((IQueryStatements input) => input.Select());
            return new SelectClauseWithDistinct<IEndQuery>(new EndQuery(this), Expression).AsNextClause(this);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<IEndQuery>> BeginOperatorGroup()
        {
            Append((IQueryStatements input) => input.BeginOperatorGroup());
            return new QueryOperatorGroupEnd<IEndQuery>(new EndQuery(this), Expression).AsOperand().AsNextClause(this);
        }

        public ICommonTableExpression With(TableAlias tableName, params ColumnAlias[] columnNames)
        {
            Append((IQueryStatements input) => input.With(null), (new ISqlString[] { tableName }).Concat(columnNames).ToArray());
            return new CommonTableExpression(tableName, columnNames, Expression, new EndQuery(this)).AsNextClause(this);
        }

        public override Expression ToExpression()
        {
            return Expression;
        }

        public void EndQuery()
        {
            Expression = base.ToExpression();
            Append((IEndQuery input) => input.Query());
        }
    }
}
