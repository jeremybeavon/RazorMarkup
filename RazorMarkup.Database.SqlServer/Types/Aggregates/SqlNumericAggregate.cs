namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlNumericAggregate : AbstractSqlAggregate, ISqlNumericType
    {
        public static implicit operator SqlNumeric(SqlNumericAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
