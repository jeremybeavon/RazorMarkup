using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Hints
{
    internal class TableHint<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, ITableHint<TEndType>
    {
        public TableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> Index(params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("INDEX({0})", string.Join(", ", indexValues)));
            Statement.Append(
                (ITableHint<TEndType> input) => input.Index(),
                indexValues.Select(value => new StringLiteral(value)).ToArray());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            Statement.Append(
                (ITableHint<TEndType> input) => input.ForceSeek(null),
                (new ISqlString[] { new StringLiteral(indexValue) }).Concat(indexValues.Select(value => new StringLiteral(value))).ToArray());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            Statement.Append((ITableHint<TEndType> input) => input.ForceScan());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            Statement.Append((ITableHint<TEndType> input) => input.ForceSeek());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.HoldLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.NoLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            Statement.Append((ITableHint<TEndType> input) => input.NoWait());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.PageLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            Statement.Append((ITableHint<TEndType> input) => input.ReadCommitted());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.ReadCommittedLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            Statement.Append((ITableHint<TEndType> input) => input.ReadPast());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            Statement.Append((ITableHint<TEndType> input) => input.ReadUncommitted());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            Statement.Append((ITableHint<TEndType> input) => input.RepeatableRead());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.RowLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            Statement.Append((ITableHint<TEndType> input) => input.Serializable());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            Statement.Append((ITableHint<TEndType> input) => input.Snapshot());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            Statement.Append((ITableHint<TEndType> input) => input.SpatialWindowMaxCells(0), new IntegerLiteral(maxCells));
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.TabLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            Statement.Append((ITableHint<TEndType> input) => input.TabLockX());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.UpdateLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            Statement.Append((ITableHint<TEndType> input) => input.XLock());
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }
    }
}
