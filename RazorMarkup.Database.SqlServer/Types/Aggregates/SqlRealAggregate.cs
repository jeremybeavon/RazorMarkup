using System;

namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public sealed class SqlRealAggregate : AbstractSqlAggregate, ISqlFloatType
    {
        public static implicit operator SqlReal(SqlRealAggregate value)
        {
            throw new NotInExpressionException();
        }
    }
}
