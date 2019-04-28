namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedByTarget
    {
        IMergeMatched Then();
    }
}
