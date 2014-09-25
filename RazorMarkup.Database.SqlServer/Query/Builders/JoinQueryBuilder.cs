namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class JoinQueryBuilder : AbstractStatementBuilder
    {
        public JoinQueryBuilder(string joinType)
        {
            JoinType = joinType;
        }

        public string JoinType { get; private set; }

        public string JoinHint { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append(JoinType);
            if (!string.IsNullOrWhiteSpace(JoinHint))
            {
                sqlBuilder.Append(" ");
                sqlBuilder.Append(JoinHint);
            }

            sqlBuilder.Append(" JOIN");
        }
    }
}
