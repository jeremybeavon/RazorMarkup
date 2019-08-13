using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class PivotQueryBuilder : AbstractTableReferenceBuilder
    {
        public PivotQueryBuilder(
            ExpressionBuilder expressionBuilder,
            string aggregateFunction,
            Expression<Func<Text>>[] aggregateValues)
            : base(expressionBuilder)
        {
            AggregateFunction = aggregateFunction;
            AggregateValues = aggregateValues;
        }

        public string AggregateFunction { get; private set; }

        public Expression<Func<Text>>[] AggregateValues { get; private set; }

        public string PivotColumn { get; set; }

        public string[] ColumnList { get; set; }

        public string TableAlias { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("PIVOT");
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.Append(AggregateFunction);
                sqlBuilder.Append("(");
                bool includeComma = false;
                foreach (Expression<Func<Text>> aggregateValue in AggregateValues)
                {
                    if (includeComma)
                    {
                        sqlBuilder.Append(", ");
                    }
                    else
                    {
                        includeComma = true;
                    }

                    aggregateValue.ToExpressionBuilder().ToSqlString(sqlBuilder);
                }

                sqlBuilder.AppendIndent();
                sqlBuilder.Append("FOR ");
                sqlBuilder.Append(PivotColumn);
                sqlBuilder.Append(" IN (");
                sqlBuilder.Append(string.Join(", ", ColumnList));
                sqlBuilder.Append(")");
            }

            sqlBuilder.AppendIndent();
            sqlBuilder.Append(")");
            if (!string.IsNullOrWhiteSpace(TableAlias))
            {
                sqlBuilder.Append(" AS ");
                sqlBuilder.Append(TableAlias);
            }
        }
    }
}
