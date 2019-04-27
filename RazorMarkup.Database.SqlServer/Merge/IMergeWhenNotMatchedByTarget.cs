namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedByTarget
    {
        object Then();
    }
}
