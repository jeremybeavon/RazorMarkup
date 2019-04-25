namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeInto : IMergeTargetTable
    {
        IMergeTargetTable Into();
    }
}
