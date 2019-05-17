namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableHint<TTableSelectionWithAdditionalTableHint> : IHideObjectMethods
    {
        TTableSelectionWithAdditionalTableHint Index(params string[] indexValues);

        TTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues);

        TTableSelectionWithAdditionalTableHint ForceScan();

        TTableSelectionWithAdditionalTableHint ForceSeek();

        TTableSelectionWithAdditionalTableHint HoldLock();

        TTableSelectionWithAdditionalTableHint NoExpand();

        TTableSelectionWithAdditionalTableHint NoLock();

        TTableSelectionWithAdditionalTableHint NoWait();

        TTableSelectionWithAdditionalTableHint PageLock();

        TTableSelectionWithAdditionalTableHint ReadCommitted();

        TTableSelectionWithAdditionalTableHint ReadCommittedLock();

        TTableSelectionWithAdditionalTableHint ReadPast();

        TTableSelectionWithAdditionalTableHint ReadUncommitted();

        TTableSelectionWithAdditionalTableHint RepeatableRead();

        TTableSelectionWithAdditionalTableHint RowLock();

        TTableSelectionWithAdditionalTableHint Serializable();

        TTableSelectionWithAdditionalTableHint Snapshot();

        TTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells);

        TTableSelectionWithAdditionalTableHint TabLock();

        TTableSelectionWithAdditionalTableHint TabLockX();

        TTableSelectionWithAdditionalTableHint UpdateLock();

        TTableSelectionWithAdditionalTableHint XLock();
    }
}
