namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeAsTableAlias : IMergeUsing
    {
        IMergeUsing Alias(TableAlias tableAlias);

        IMergeUsing As(TableAlias tableAlias);
    }
}
