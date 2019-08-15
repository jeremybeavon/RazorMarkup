using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    public interface ISetClauseAnd : ICommonSetClauseAnd<ISetColumn, ISetVariable>, IMergeWhen
    {
    }
}
