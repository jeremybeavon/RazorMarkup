namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedBySource
    {
        object Then();
    }
}
