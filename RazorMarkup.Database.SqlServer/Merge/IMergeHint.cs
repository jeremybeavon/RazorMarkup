namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeHint : IHideObjectMethods
    {
        IMergeHintAnd KeepIdentity();

        IMergeHintAnd KeepDefaults();

        IMergeHintAnd HoldLock();

        IMergeHintAnd IgnoreConstraints();

        IMergeHintAnd IgnoreTriggers();

        IMergeHintAnd NoWait();

        IMergeHintAnd PagLock();

        IMergeHintAnd ReadCommitted();

        IMergeHintAnd ReadCommittedLock();

        IMergeHintAnd ReadPast();

        IMergeHintAnd RepeatableRead();

        IMergeHintAnd RowLock();

        IMergeHintAnd Serializable();

        IMergeHintAnd Snapshot();

        IMergeHintAnd TabLock();

        IMergeHintAnd TabLockX();

        IMergeHintAnd UpdLock();

        IMergeHintAnd XLock();

        IMergeHintAnd Index(string indexValue, params string[] indexValues);
    }
}
