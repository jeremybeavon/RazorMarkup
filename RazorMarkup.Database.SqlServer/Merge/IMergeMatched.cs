using RazorMarkup.Database.SqlServer.Merge.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeMatched : IHideObjectMethods
    {
        ISetClause UpdateSet();

        IEndWhenClause Delete();
    }
}
