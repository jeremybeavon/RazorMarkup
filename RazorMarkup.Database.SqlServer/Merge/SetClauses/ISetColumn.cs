using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    public interface ISetColumn : ICommonSetColumn<ISetClauseAnd, ISetFieldOrProperty>
    {
    }
}
