namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableHint
    {
        ICommonTableSelectionWithAdditionalTableHint Index(params string[] indexValues);

        ICommonTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues);

        ICommonTableSelectionWithAdditionalTableHint ForceScan();

        ICommonTableSelectionWithAdditionalTableHint ForceSeek();

        ICommonTableSelectionWithAdditionalTableHint HoldLock();

        ICommonTableSelectionWithAdditionalTableHint NoExpand();

        ICommonTableSelectionWithAdditionalTableHint NoLock();

        ICommonTableSelectionWithAdditionalTableHint NoWait();

        ICommonTableSelectionWithAdditionalTableHint PageLock();

        ICommonTableSelectionWithAdditionalTableHint ReadCommitted();

        ICommonTableSelectionWithAdditionalTableHint ReadCommittedLock();

        ICommonTableSelectionWithAdditionalTableHint ReadPast();

        ICommonTableSelectionWithAdditionalTableHint ReadUncommitted();

        ICommonTableSelectionWithAdditionalTableHint RepeatableRead();

        ICommonTableSelectionWithAdditionalTableHint RowLock();

        ICommonTableSelectionWithAdditionalTableHint Serializable();

        ICommonTableSelectionWithAdditionalTableHint Snapshot();

        ICommonTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells);

        ICommonTableSelectionWithAdditionalTableHint TabLock();

        ICommonTableSelectionWithAdditionalTableHint TabLockX();

        ICommonTableSelectionWithAdditionalTableHint UpdateLock();

        ICommonTableSelectionWithAdditionalTableHint XLock();
    }
}
