namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryBuilder : AbstractStatementBuilder
    {
        public SubqueryBuilder()
        {
            Select = new SelectClauseBuilder();
        }

        public SelectClauseBuilder Select { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                Select.ToSqlString(sqlBuilder);
            }

            sqlBuilder.Append(")");
        }
    }
}
