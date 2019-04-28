using RazorMarkup.Database.SqlServer.Merge.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeMatched : IHideObjectMethods
    {
        ISetClause UpdateSet();

        IEndWhenClause Delete();
    }
}
