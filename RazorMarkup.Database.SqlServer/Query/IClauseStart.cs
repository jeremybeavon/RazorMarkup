using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal interface IClauseStart<T>
    {
        T AsNextClause(ClauseBuilder statement);
    }
}
