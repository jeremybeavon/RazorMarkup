using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SelectClauseBuilder : ClauseBuilder
    {
        public SelectClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Columns = new List<SelectColumnBuilder>();
        }

        public bool? IsDistinct { get; set; }

        public ExpressionBuilder<Integer> Top { get; set; }

        public bool IsPercent { get; set; }

        public bool WithTies { get; set; }

        public string IntoTable { get; set; }

        public IList<SelectColumnBuilder> Columns { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("SELECT ");
            WriteDistinctOrAll(sqlBuilder);
            WriteTop(sqlBuilder);
            WriteColumns(sqlBuilder);
            WriteInto(sqlBuilder);
            base.ToSqlString(sqlBuilder);
        }

        private void WriteDistinctOrAll(SqlBuilder sqlBuilder)
        {
            if (IsDistinct.HasValue)
            {
                sqlBuilder.Append(IsDistinct.Value ? "DISTINCT " : "ALL ");
            }
        }

        private void WriteTop(SqlBuilder sqlBuilder)
        {
            if (Top != null)
            {
                sqlBuilder.Append("TOP ");
                Top.ToSqlString(sqlBuilder);
                sqlBuilder.Append(" ");
                if (IsPercent)
                {
                    sqlBuilder.Append("PERCENT ");
                }

                if (WithTies)
                {
                    sqlBuilder.Append("WITH TIES ");
                }
            }
        }

        private void WriteColumns(SqlBuilder sqlBuilder)
        {
            if (Columns.Count == 0)
            {
                return;
            }

            Columns[0].ToSqlString(sqlBuilder);
            if (Columns.Count > 1)
            {
                using (sqlBuilder.IncrementIndent())
                { 
                    foreach (AbstractStatementTextBuilder column in Columns.Skip(1))
                    {
                        sqlBuilder.Append(",").AppendIndent();
                        column.ToSqlString(sqlBuilder);
                    }
                }
            }
        }

        private void WriteInto(SqlBuilder sqlBuilder)
        {
            if (!string.IsNullOrWhiteSpace(IntoTable))
            {
                sqlBuilder.AppendIndent().Append("INTO ");
                sqlBuilder.Append(IntoTable);
            }
        }
    }
}
