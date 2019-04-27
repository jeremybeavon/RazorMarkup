namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableHint<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithAdditionalTableHint<TEndType> Index(params string[] indexValues);

        ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek(string indexValue, params string[] indexValues);

        ITableSelectionWithAdditionalTableHint<TEndType> ForceScan();

        ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek();

        ITableSelectionWithAdditionalTableHint<TEndType> HoldLock();

        ITableSelectionWithAdditionalTableHint<TEndType> NoExpand();

        ITableSelectionWithAdditionalTableHint<TEndType> NoLock();

        ITableSelectionWithAdditionalTableHint<TEndType> NoWait();

        ITableSelectionWithAdditionalTableHint<TEndType> PageLock();

        ITableSelectionWithAdditionalTableHint<TEndType> ReadCommitted();

        ITableSelectionWithAdditionalTableHint<TEndType> ReadCommittedLock();

        ITableSelectionWithAdditionalTableHint<TEndType> ReadPast();

        ITableSelectionWithAdditionalTableHint<TEndType> ReadUncommitted();

        ITableSelectionWithAdditionalTableHint<TEndType> RepeatableRead();

        ITableSelectionWithAdditionalTableHint<TEndType> RowLock();

        ITableSelectionWithAdditionalTableHint<TEndType> Serializable();

        ITableSelectionWithAdditionalTableHint<TEndType> Snapshot();

        ITableSelectionWithAdditionalTableHint<TEndType> SpatialWindowMaxCells(int maxCells);

        ITableSelectionWithAdditionalTableHint<TEndType> TabLock();

        ITableSelectionWithAdditionalTableHint<TEndType> TabLockX();

        ITableSelectionWithAdditionalTableHint<TEndType> UpdateLock();

        ITableSelectionWithAdditionalTableHint<TEndType> XLock();
    }
}
