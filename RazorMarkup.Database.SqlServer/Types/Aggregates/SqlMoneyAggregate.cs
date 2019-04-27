namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlMoneyAggregate : AbstractSqlAggregate, ISqlFloatType
    {
        public static implicit operator SqlDecimal(SqlMoneyAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
