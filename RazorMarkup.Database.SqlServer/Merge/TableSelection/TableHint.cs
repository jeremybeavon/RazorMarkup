using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableHint : AbstractStatement<FromClauseBuilder>, ITableHint
    {
        public TableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithAdditionalTableHint Index(params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("INDEX({0})", string.Join(", ", indexValues)));
            Statement.Append(
                (ITableHint input) => input.Index(),
                indexValues.Select(value => new StringLiteral(value)).ToArray());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            Statement.Append(
                (ITableHint input) => input.ForceSeek(null),
                (new ISqlString[] { new StringLiteral(indexValue) }).Concat(indexValues.Select(value => new StringLiteral(value))).ToArray());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            Statement.Append((ITableHint input) => input.ForceScan());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            Statement.Append((ITableHint input) => input.ForceSeek());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            Statement.Append((ITableHint input) => input.HoldLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint NoExpand()
        {
            Statement.CurrentTable.TableHints.Add("NOEXPAND");
            Statement.Append((ITableHint input) => input.NoExpand());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            Statement.Append((ITableHint input) => input.NoLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            Statement.Append((ITableHint input) => input.NoWait());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            Statement.Append((ITableHint input) => input.PageLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            Statement.Append((ITableHint input) => input.ReadCommitted());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            Statement.Append((ITableHint input) => input.ReadCommittedLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            Statement.Append((ITableHint input) => input.ReadPast());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            Statement.Append((ITableHint input) => input.ReadUncommitted());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            Statement.Append((ITableHint input) => input.RepeatableRead());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            Statement.Append((ITableHint input) => input.RowLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            Statement.Append((ITableHint input) => input.Serializable());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            Statement.Append((ITableHint input) => input.Snapshot());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            Statement.Append((ITableHint input) => input.SpatialWindowMaxCells(0), new IntegerLiteral(maxCells));
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            Statement.Append((ITableHint input) => input.TabLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            Statement.Append((ITableHint input) => input.TabLockX());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            Statement.Append((ITableHint input) => input.UpdateLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            Statement.Append((ITableHint input) => input.XLock());
            return new TableSelectionWithAdditionalTableHint(Statement);
        }
    }
}
