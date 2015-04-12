using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableHint<TEndType> : ICommonTableHint
    {
        private readonly ITableHint<TEndType> tableHint;

        public CommonTableHint(ITableHint<TEndType> tableHint)
        {
            this.tableHint = tableHint;
        }

        public ICommonTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.Index(indexValues));
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ForceSeek(indexValue, indexValues));
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceScan()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ForceScan());
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ForceSeek());
        }

        public ICommonTableSelectionWithAdditionalTableHint HoldLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.HoldLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint NoExpand()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.NoExpand());
        }

        public ICommonTableSelectionWithAdditionalTableHint NoLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.NoLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint NoWait()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.NoWait());
        }

        public ICommonTableSelectionWithAdditionalTableHint PageLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.PageLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ReadCommitted());
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ReadCommittedLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadPast()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ReadPast());
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.ReadUncommitted());
        }

        public ICommonTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.RepeatableRead());
        }

        public ICommonTableSelectionWithAdditionalTableHint RowLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.RowLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint Serializable()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.Serializable());
        }

        public ICommonTableSelectionWithAdditionalTableHint Snapshot()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.Snapshot());
        }

        public ICommonTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.SpatialWindowMaxCells(maxCells));
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.TabLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLockX()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.TabLockX());
        }

        public ICommonTableSelectionWithAdditionalTableHint UpdateLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.UpdateLock());
        }

        public ICommonTableSelectionWithAdditionalTableHint XLock()
        {
            return new CommonTableSelectionWithAdditionalTableHint<TEndType>(tableHint.XLock());
        }
    }
}
