using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints
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
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }

        public ITableSelectionWithAdditionalTableHint XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            return new TableSelectionWithAdditionalTableHint(Statement);
        }
    }
}
