namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlDecimalAggregate : AbstractSqlAggregate, ISqlFloatType
    {
        public static implicit operator SqlDecimal(SqlDecimalAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
