using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SelectColumnBuilder : AbstractStatementBuilder
    {
        public SelectColumnBuilder(string columnName)
        {
            ColumnName = columnName;
        }

        public SelectColumnBuilder(Expression<Func<object>> columnExpression)
        {
            ColumnExpression = new ExpressionBuilder<object>(columnExpression);
        }

        public string ColumnName { get; set; }

        public ExpressionBuilder<object> ColumnExpression { get; private set; }

        public string Alias { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(" ");
            if (ColumnExpression == null)
            {
                sqlBuilder.Append(ColumnName);
            }
            else
            {
                ColumnExpression.ToSqlString(sqlBuilder);
            }

            if (!string.IsNullOrWhiteSpace(Alias))
            {
                sqlBuilder.Append(" AS ");
                sqlBuilder.Append(Alias);
            }
        }
    }
}
