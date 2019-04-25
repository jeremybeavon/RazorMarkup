namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWithHint : IMergeAsTableAlias
    {
        IMergeHint With();
    }
}
