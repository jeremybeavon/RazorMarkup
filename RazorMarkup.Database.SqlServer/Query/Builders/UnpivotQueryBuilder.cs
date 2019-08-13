namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class UnpivotQueryBuilder : AbstractTableReferenceBuilder
    {
        public UnpivotQueryBuilder(ExpressionBuilder expressionBuilder, string columnName)
            : base(expressionBuilder)
        {
            ColumnName = columnName;
        }

        public string ColumnName { get; private set; }

        public string PivotColumn { get; set; }

        public string[] ColumnList { get; set; }

        public string TableAlias { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("UNPIVOT (");
            sqlBuilder.Append(ColumnName);
            sqlBuilder.Append("FOR ");
            sqlBuilder.Append(PivotColumn);
            sqlBuilder.Append(" IN (");
            sqlBuilder.Append(string.Join(", ", ColumnList));
            sqlBuilder.Append("))");
            if (!string.IsNullOrWhiteSpace(TableAlias))
            {
                sqlBuilder.Append(" AS ");
                sqlBuilder.Append(TableAlias);
            }
        }
    }
}
