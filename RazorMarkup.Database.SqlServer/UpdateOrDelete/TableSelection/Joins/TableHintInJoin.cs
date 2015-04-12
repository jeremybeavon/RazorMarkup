using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal class TableHintInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>, ITableHintInJoin<TJoinEndType>
    {
        public TableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Index(params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("INDEX({0})", string.Join(", ", indexValues)));
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoExpand()
        {
            Statement.CurrentTable.TableHints.Add("NOEXPAND");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
