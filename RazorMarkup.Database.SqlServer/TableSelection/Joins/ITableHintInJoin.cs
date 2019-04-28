namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableHintInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Index(params string[] indexValues);

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek(string indexValue, params string[] indexValues);

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceScan();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> HoldLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoExpand();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoWait();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> PageLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommitted();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommittedLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadPast();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadUncommitted();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RepeatableRead();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RowLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Serializable();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Snapshot();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> SpatialWindowMaxCells(int maxCells);

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLockX();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> UpdateLock();

        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> XLock();
    }
}
