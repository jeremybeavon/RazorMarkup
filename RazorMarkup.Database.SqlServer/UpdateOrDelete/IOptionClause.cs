using RazorMarkup.Database.SqlServer.Query.Option;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    public interface IOptionClause
    {
        IQueryHint WithOption();
    }
}
