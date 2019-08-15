namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeTargetTableWithAlias : IMergeUsing
    {
        IMergeUsing As(TableAlias table);
    }
}
