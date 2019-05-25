using System;
using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableHint<TJoinEndType, TTableSelectionWithAdditionalTableHint> :
        AbstractTableSelectionStatement<TJoinEndType>,
        ICommonTableHint<TTableSelectionWithAdditionalTableHint>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder;

        protected CommonTableHint(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAdditionalTableHint> tableSelectionWithAdditionalTableHintBuilder)
            : base(statement, joinClosure)
        {
            this.tableSelectionWithAdditionalTableHintBuilder = tableSelectionWithAdditionalTableHintBuilder;
        }

        public TTableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("INDEX({0})", string.Join(", ", indexValues)));
            Statement.Append(
                (ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Index(),
                indexValues.Select(value => new StringLiteral(value)).ToArray());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            Statement.Append(
                (ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceSeek(null),
                (new ISqlString[] { new StringLiteral(indexValue) }).Concat(indexValues.Select(value => new StringLiteral(value))).ToArray());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceScan());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ForceSeek());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.HoldLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint NoExpand()
        {
            Statement.CurrentTable.TableHints.Add("NOEXPAND");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoExpand());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.NoWait());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.PageLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadCommitted());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadCommittedLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadPast());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.ReadUncommitted());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.RepeatableRead());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.RowLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Serializable());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.Snapshot());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.SpatialWindowMaxCells(0), new IntegerLiteral(maxCells));
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.TabLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.TabLockX());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.UpdateLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAdditionalTableHint XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            Statement.Append((ICommonTableHint<TTableSelectionWithAdditionalTableHint> input) => input.XLock());
            return tableSelectionWithAdditionalTableHintBuilder(Statement, JoinClosure);
        }
    }
}
