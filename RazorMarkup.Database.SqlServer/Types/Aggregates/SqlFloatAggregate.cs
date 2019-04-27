namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlFloatAggregate : AbstractSqlAggregate, ISqlFloatType
    {
        public static implicit operator SqlFloat(SqlFloatAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
