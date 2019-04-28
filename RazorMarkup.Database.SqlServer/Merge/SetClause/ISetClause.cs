using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    public interface ISetClause : ICommonSetClause<ISetColumn, ISetVariable>
    {
    }
}
