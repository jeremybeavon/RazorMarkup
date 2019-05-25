using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class AdditionalCommonTableHint<
        TJoinEndType,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TTableSelectionWithAdditionalTableHint,
        TAdditionalCommonTableHint> :
        CommonTableSource<
            TJoinEndType,
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TAdditionalCommonTableHint>,
        IAdditionalCommonTableHint<
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TTableSelectionWithAdditionalTableHint>
        where TAdditionalCommonTableHint : IAdditionalCommonTableHint<
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TTableSelectionWithAdditionalTableHint>
    {
        private readonly ICommonTableHint<TTableSelectionWithAdditionalTableHint> tableHint;

        protected AdditionalCommonTableHint(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAlias> tableSelectionWithAliasBuilder,
            Func<FromClauseBuilder, TJoinEndType, TSubqueryWithAlias> subqueryWithAliasBuilder,
            Func<FromClauseBuilder, TJoinEndType, DerivedTableBuilder, TDerivedTableWithAlias> derivedTableWithAliasBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder)
            : base(
                  statement,
                  joinClosure,
                  tableSelectionWithAliasBuilder,
                  subqueryWithAliasBuilder,
                  derivedTableWithAliasBuilder)
        {
            tableHint = new InternalCommonTableHint(statement, joinClosure, tableSelectionWithAdditionalTableHintBuilder);
        }

        public TTableSelectionWithAdditionalTableHint ForceScan()
        {
            return tableHint.ForceScan();
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            return tableHint.ForceSeek(indexValue, indexValues);
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek()
        {
            return tableHint.ForceSeek();
        }

        public TTableSelectionWithAdditionalTableHint HoldLock()
        {
            return tableHint.HoldLock();
        }

        public TTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            return tableHint.Index(indexValues);
        }

        public TTableSelectionWithAdditionalTableHint NoExpand()
        {
            return tableHint.NoExpand();
        }

        public TTableSelectionWithAdditionalTableHint NoLock()
        {
            return tableHint.NoLock();
        }

        public TTableSelectionWithAdditionalTableHint NoWait()
        {
            return tableHint.NoWait();
        }

        public TTableSelectionWithAdditionalTableHint PageLock()
        {
            return tableHint.PageLock();
        }

        public TTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            return tableHint.ReadCommitted();
        }

        public TTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            return tableHint.ReadCommittedLock();
        }

        public TTableSelectionWithAdditionalTableHint ReadPast()
        {
            return tableHint.ReadPast();
        }

        public TTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            return tableHint.ReadUncommitted();
        }

        public TTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            return tableHint.RepeatableRead();
        }

        public TTableSelectionWithAdditionalTableHint RowLock()
        {
            return tableHint.RowLock();
        }

        public TTableSelectionWithAdditionalTableHint Serializable()
        {
            return tableHint.Serializable();
        }

        public TTableSelectionWithAdditionalTableHint Snapshot()
        {
            return tableHint.Snapshot();
        }

        public TTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            return tableHint.SpatialWindowMaxCells(maxCells);
        }

        public TTableSelectionWithAdditionalTableHint TabLock()
        {
            return tableHint.TabLock();
        }

        public TTableSelectionWithAdditionalTableHint TabLockX()
        {
            return tableHint.TabLockX();
        }

        public TTableSelectionWithAdditionalTableHint UpdateLock()
        {
            return tableHint.UpdateLock();
        }

        public TTableSelectionWithAdditionalTableHint XLock()
        {
            return tableHint.XLock();
        }

        private sealed class InternalCommonTableHint : CommonTableHint<TJoinEndType, TTableSelectionWithAdditionalTableHint>
        {
            public InternalCommonTableHint(
                FromClauseBuilder statement,
                TJoinEndType joinClosure,
                Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder)
                : base(statement, joinClosure, tableSelectionWithAdditionalTableHintBuilder)
            {
            }
        }
    }
}
