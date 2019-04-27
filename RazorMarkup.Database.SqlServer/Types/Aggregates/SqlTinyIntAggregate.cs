namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlTinyIntAggregate : AbstractSqlAggregate, ISqlIntegerType
    {
        public static implicit operator SqlTinyInt(SqlTinyIntAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
