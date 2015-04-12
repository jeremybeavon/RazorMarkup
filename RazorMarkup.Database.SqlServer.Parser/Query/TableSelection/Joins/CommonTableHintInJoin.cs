using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableHintInJoin<TEndType> : AbstractJoinStatement<TEndType>, ICommonTableHint
    {
        private readonly ITableHintInJoin<TEndType> tableHint;

        public CommonTableHintInJoin(
            ITableHintInJoin<TEndType> tableHint,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.tableHint = tableHint;
        }

        public ICommonTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.Index(indexValues), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(
                tableHint.ForceSeek(indexValue, indexValues),
                EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceScan()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ForceScan(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ForceSeek(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint HoldLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.HoldLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint NoExpand()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.NoExpand(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint NoLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.NoLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint NoWait()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.NoWait(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint PageLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.PageLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ReadCommitted(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ReadCommittedLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadPast()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ReadPast(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.ReadUncommitted(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.RepeatableRead(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint RowLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.RowLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint Serializable()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(
                tableHint.Serializable(),
                EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint Snapshot()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.Snapshot(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.SpatialWindowMaxCells(maxCells), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.TabLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLockX()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.TabLockX(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint UpdateLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.UpdateLock(), EndClosure);
        }

        public ICommonTableSelectionWithAdditionalTableHint XLock()
        {
            return new CommonTableSelectionWithAdditionalTableHintInJoin<TEndType>(tableHint.XLock(), EndClosure);
        }
    }
}
