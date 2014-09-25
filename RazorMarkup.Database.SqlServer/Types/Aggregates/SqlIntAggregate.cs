using System;

namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlIntAggregate : AbstractSqlAggregate, ISqlIntegerType
    {
        public static implicit operator SqlInt(SqlIntAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
