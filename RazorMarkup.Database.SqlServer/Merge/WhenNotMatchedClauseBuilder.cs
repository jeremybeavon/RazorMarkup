using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class WhenNotMatchedClauseBuilder : AbstractWhenClauseBuilder
    {
        public WhenNotMatchedClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public bool IncludeByTarget { get; set; }

        public ExpressionBuilder<bool> ClauseSearchCondition { get; set; }

        public List<string> ColumnNames { get; } = new List<string>();

        public List<ExpressionBuilder<object>> Values { get; } = new List<ExpressionBuilder<object>>();

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("WHEN NOT MATCHED");
            if (IncludeByTarget)
            {
                sqlBuilder.Append(" BY TARGET");
            }

            if (ClauseSearchCondition != null)
            {
                sqlBuilder.Append(" AND ");
                ClauseSearchCondition.ToSqlString(sqlBuilder);
            }

            sqlBuilder.AppendIndent();
            sqlBuilder.Append("THEN INSERT ");
            if (ColumnNames.Count != 0)
            {
                sqlBuilder.Append("(");
                sqlBuilder.Append(ColumnNames[0]);
                foreach (string columnName in ColumnNames.Skip(1))
                {
                    sqlBuilder.Append(", ");
                    sqlBuilder.Append(columnName);
                }

                sqlBuilder.Append(")");
                sqlBuilder.AppendIndent();
            }

            if (Values.Count == 0)
            {
                sqlBuilder.Append("DEFAULT VALUES");
            }
            else
            {
                sqlBuilder.Append("VALUES (");
                Values[0].ToSqlString(sqlBuilder);
                foreach (ExpressionBuilder<object> value in Values)
                {
                    sqlBuilder.Append(", ");
                    value.ToSqlString(sqlBuilder);
                }

                sqlBuilder.Append(")");
            }
        }
    }
}
