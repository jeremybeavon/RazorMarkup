using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableHint<TTableSelectionWithAdditionalTableHint> :
        AbstractStatement<FromClauseBuilder>,
        ICommonTableHint<TTableSelectionWithAdditionalTableHint>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder;

        protected CommonTableHint(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder)
            : base(statement)
        {
            this.tableSelectionWithAdditionalTableHintBuilder = tableSelectionWithAdditionalTableHintBuilder;
        }

        public TTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("INDEX({0})", string.Join(", ", indexValues)));
            Statement.Append(
                (ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Index(),
                indexValues.Select(value => new StringLiteral(value)).ToArray());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            Statement.Append(
                (ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceSeek(null),
                (new ISqlString[] { new StringLiteral(indexValue) }).Concat(indexValues.Select(value => new StringLiteral(value))).ToArray());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceScan());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceSeek());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.HoldLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint NoExpand()
        {
            Statement.CurrentTable.TableHints.Add("NOEXPAND");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoExpand());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoWait());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.PageLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadCommitted());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadCommittedLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadPast());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadUncommitted());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.RepeatableRead());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.RowLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Serializable());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Snapshot());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.SpatialWindowMaxCells(0), new IntegerLiteral(maxCells));
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.TabLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.TabLockX());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.UpdateLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }

        public TTableSelectionWithAdditionalTableHint XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.XLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement);
        }
    }
}
