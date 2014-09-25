using System;

namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlSmallMoneyAggregate : AbstractSqlAggregate, ISqlFloatType
    {
        public static implicit operator SqlSmallMoney(SqlSmallMoneyAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
