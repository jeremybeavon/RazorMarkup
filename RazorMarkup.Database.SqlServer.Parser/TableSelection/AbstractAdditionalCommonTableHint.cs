using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractAdditionalCommonTableHint<
        TAdditionalTableHint,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TTableSelectionWithAdditionalTableHint,
        TCommonTableSelectionWithAlias,
        TCommonSubqueryWithAlias,
        TCommonDerivedTableWithAlias,
        TCommonTableSelectionWithAdditionalTableHint> :
        AbstractCommonTableSource<
            TAdditionalTableHint,
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TCommonTableSelectionWithAlias,
            TCommonSubqueryWithAlias,
            TCommonDerivedTableWithAlias>,
        ICommonAdditionalTableHint
        where TAdditionalTableHint : IAdditionalCommonTableHint<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias, TTableSelectionWithAdditionalTableHint>
        where TCommonTableSelectionWithAlias : ISource<TTableSelectionWithAlias>, ICommonTableSelectionWithAlias, new()
        where TCommonSubqueryWithAlias : ISource<TSubqueryWithAlias>, ICommonSubqueryWithAlias, new()
        where TCommonDerivedTableWithAlias : ISource<TDerivedTableWithAlias>, ICommonDerivedTableWithAlias, new()
        where TCommonTableSelectionWithAdditionalTableHint : ISource<TTableSelectionWithAdditionalTableHint>, ICommonTableSelectionWithAdditionalTableHint, new()
    {
        public ICommonTableSelectionWithAdditionalTableHint ForceScan()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ForceScan()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ForceSeek(indexValue, indexValues)
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ForceSeek()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ForceSeek()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint HoldLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.HoldLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.Index(indexValues)
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint NoExpand()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.NoExpand()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint NoLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.NoLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint NoWait()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.NoWait()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint PageLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.PageLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ReadCommitted()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ReadCommittedLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadPast()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ReadPast()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.ReadUncommitted()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.RepeatableRead()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint RowLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.RowLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint Serializable()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.Serializable()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint Snapshot()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.Snapshot()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.SpatialWindowMaxCells(maxCells)
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.TabLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint TabLockX()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.TabLockX()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint UpdateLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.UpdateLock()
            };
        }

        public ICommonTableSelectionWithAdditionalTableHint XLock()
        {
            return new TCommonTableSelectionWithAdditionalTableHint()
            {
                Source = Source.XLock()
            };
        }
    }
}
