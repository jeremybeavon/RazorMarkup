using RazorMarkup.Database.SqlServer.Expressions.Functions;

namespace RazorMarkup.Database.SqlServer.Types.Aggregates
{
    public abstract class AbstractSqlAggregate
    {
        public IOverClause Over()
        {
            throw new NotInExpressionException();
        }
    }
}
