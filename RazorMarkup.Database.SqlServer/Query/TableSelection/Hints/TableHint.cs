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
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            return new TableSelectionWithAdditionalTableHint<TEndType>(Statement, EndClosure);
        }
    }
}
