using System;

namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlSmallIntAggregate : AbstractSqlAggregate, ISqlIntegerType
    {
        public static implicit operator SqlSmallInt(SqlSmallIntAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
