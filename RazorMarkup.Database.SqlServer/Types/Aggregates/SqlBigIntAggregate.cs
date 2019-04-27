namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlBigIntAggregate : AbstractSqlAggregate, ISqlIntegerType
    {
        public static implicit operator SqlBigInt(SqlBigIntAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
