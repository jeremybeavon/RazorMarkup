namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhen : IHideObjectMethods
    {
        IMergeWhenMatchedAnd WhenMatched();

        IMergeWhenNotMatchedByTargetAnd WhenNotMatched();

        IMergeWhenNotMatchedByTargetAnd WhenNotMatchedByTarget();

        IMergeWhenNotMatchedBySourceAnd WhenNotMatchedBySource();
    }
}
