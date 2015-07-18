using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class WithClauseBuilder : ClauseBuilder
    {
        public WithClauseBuilder(ExpressionBuilder expressionBuilder, TableAlias tableName, IEnumerable<ColumnAlias> columnNames)
            : base(expressionBuilder)
        {
            CommonTableExpressions = new List<CommonTableExpressionBuilder>()
            {
                new CommonTableExpressionBuilder(expressionBuilder, tableName, columnNames)
            };
        }

        public IList<CommonTableExpressionBuilder> CommonTableExpressions { get; private set; }

        public CommonTableExpressionBuilder LastExpression
        {
            get { return CommonTableExpressions[CommonTableExpressions.Count - 1]; }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (CommonTableExpressions.Count == 0)
            {
                return;
            }

            sqlBuilder.AppendIndent().Append("WITH ");
            CommonTableExpressions[0].ToSqlString(sqlBuilder);
            foreach (CommonTableExpressionBuilder commonTableExpression in CommonTableExpressions)
            {
                sqlBuilder.Append(",");
                commonTableExpression.ToSqlString(sqlBuilder);
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
