namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class RawTableReferenceBuilder : AbstractTableReferenceBuilder
    {
        private readonly string sql;

        public RawTableReferenceBuilder(ExpressionBuilder expressionBuilder, string sql)
            : base(expressionBuilder)
        {
            this.sql = sql;
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(sql);
        }
    }
}
