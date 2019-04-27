namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    internal sealed class PartitionFunctionBuilder : AbstractStatementTextBuilder
    {
        public DatabaseName DatabaseName { get; set; }

        public PartitionFunctionName FunctionName { get; set; }

        public ExpressionBuilder<object> Parameter { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (DatabaseName != null)
            {
                sqlBuilder.Append(DatabaseName.ToSqlString());
                sqlBuilder.Append(".");
            }

            sqlBuilder.Append("$PARTITION.");
            sqlBuilder.Append(FunctionName.ToSqlString());
            sqlBuilder.Append("(");
            Parameter.ToSqlString(sqlBuilder);
            sqlBuilder.Append(")");
        }
    }
}
