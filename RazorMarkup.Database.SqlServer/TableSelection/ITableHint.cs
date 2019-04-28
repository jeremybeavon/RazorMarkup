namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableHint : IHideObjectMethods
    {
        ITableSelectionWithAdditionalTableHint Index(params string[] indexValues);

        ITableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues);

        ITableSelectionWithAdditionalTableHint ForceScan();

        ITableSelectionWithAdditionalTableHint ForceSeek();

        ITableSelectionWithAdditionalTableHint HoldLock();

        ITableSelectionWithAdditionalTableHint NoExpand();

        ITableSelectionWithAdditionalTableHint NoLock();

        ITableSelectionWithAdditionalTableHint NoWait();

        ITableSelectionWithAdditionalTableHint PageLock();

        ITableSelectionWithAdditionalTableHint ReadCommitted();

        ITableSelectionWithAdditionalTableHint ReadCommittedLock();

        ITableSelectionWithAdditionalTableHint ReadPast();

        ITableSelectionWithAdditionalTableHint ReadUncommitted();

        ITableSelectionWithAdditionalTableHint RepeatableRead();

        ITableSelectionWithAdditionalTableHint RowLock();

        ITableSelectionWithAdditionalTableHint Serializable();

        ITableSelectionWithAdditionalTableHint Snapshot();

        ITableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells);

        ITableSelectionWithAdditionalTableHint TabLock();

        ITableSelectionWithAdditionalTableHint TabLockX();

        ITableSelectionWithAdditionalTableHint UpdateLock();

        ITableSelectionWithAdditionalTableHint XLock();
    }
}
