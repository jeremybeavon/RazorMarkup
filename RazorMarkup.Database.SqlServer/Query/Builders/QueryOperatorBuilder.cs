namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class QueryOperatorBuilder : ClauseBuilder
    {
        public QueryOperatorBuilder(ExpressionBuilder expressionBuilder, string @operator)
            : base(expressionBuilder)
        {
            Operator = @operator;
        }

        public string Operator { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append(Operator);
            base.ToSqlString(sqlBuilder);
        }
    }
}
