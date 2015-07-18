using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryBuilder : AbstractTableReferenceBuilder
    {
        public SubqueryBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Select = new ClauseBuilder(expressionBuilder);
            ColumnAlias = new List<string>();
        }

        public ClauseBuilder Select { get; private set; }

        public string TableAlias { get; set; }

        public IList<string> ColumnAlias { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                Select.ToSqlString(sqlBuilder);
            }

            sqlBuilder.AppendIndent();
            sqlBuilder.Append(")");
            if (!string.IsNullOrWhiteSpace(TableAlias))
            {
                sqlBuilder.Append(" AS ");
                sqlBuilder.Append(TableAlias);
                if (ColumnAlias.Count != 0)
                {
                    sqlBuilder.Append("(");
                    sqlBuilder.Append(string.Join(", ", ColumnAlias));
                    sqlBuilder.Append(")");
                }
            }
        }
    }
}
