using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class DerivedTableBuilder : AbstractTableReferenceBuilder
    {
        public DerivedTableBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            ColumnAlias = new List<string>();
        }

        public Expression<Func<object>>[][] Values { get; set; }

        public string TableAlias { get; set; }

        public IList<string> ColumnAlias { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("(VALUES ");
            string comma = string.Empty;
            foreach (Expression<Func<object>>[] row in Values)
            {
                sqlBuilder.Append(comma);
                sqlBuilder.Append("(");
                string columnComma = string.Empty;
                foreach (Expression<Func<object>> column in row)
                {
                    sqlBuilder.Append(columnComma);
                    column.ToExpressionBuilder().ToSqlString(sqlBuilder);
                    columnComma = ", ";
                }

                sqlBuilder.Append(")");
                comma = ", ";
            }

            sqlBuilder.Append(") AS ");
            sqlBuilder.Append(TableAlias);
            sqlBuilder.Append("(");
            sqlBuilder.Append(string.Join(", ", ColumnAlias));
            sqlBuilder.Append(")");
        }
    }
}
