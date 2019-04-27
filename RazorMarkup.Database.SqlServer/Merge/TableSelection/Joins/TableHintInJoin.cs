using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
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
            Statement.Append(
                (ITableHintInJoin<TJoinEndType> input) => input.Index(),
                indexValues.Select(value => new StringLiteral(value)).ToArray());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek(string indexValue, params string[] indexValues)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("FORCESEEK({0},({1}))", indexValue, string.Join(", ", indexValues)));
            Statement.Append(
                (ITableHintInJoin<TJoinEndType> input) => input.ForceSeek(null),
                (new ISqlString[] { new StringLiteral(indexValue) }).Concat(indexValues.Select(value => new StringLiteral(value))).ToArray());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceScan()
        {
            Statement.CurrentTable.TableHints.Add("FORCESCAN");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ForceScan());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ForceSeek()
        {
            Statement.CurrentTable.TableHints.Add("FORCESEEK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ForceSeek());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> HoldLock()
        {
            Statement.CurrentTable.TableHints.Add("HOLDLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.HoldLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoExpand()
        {
            Statement.CurrentTable.TableHints.Add("NOEXPAND");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.NoExpand());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoLock()
        {
            Statement.CurrentTable.TableHints.Add("NOLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.NoLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> NoWait()
        {
            Statement.CurrentTable.TableHints.Add("NOWAIT");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.NoWait());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> PageLock()
        {
            Statement.CurrentTable.TableHints.Add("PAGLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.PageLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommitted()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTED");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ReadCommitted());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadCommittedLock()
        {
            Statement.CurrentTable.TableHints.Add("READCOMMITTEDLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ReadCommittedLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadPast()
        {
            Statement.CurrentTable.TableHints.Add("READPAST");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ReadPast());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> ReadUncommitted()
        {
            Statement.CurrentTable.TableHints.Add("READUNCOMMITTED");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.ReadUncommitted());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RepeatableRead()
        {
            Statement.CurrentTable.TableHints.Add("REPEATABLEREAD");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.RepeatableRead());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> RowLock()
        {
            Statement.CurrentTable.TableHints.Add("ROWLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.RowLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Serializable()
        {
            Statement.CurrentTable.TableHints.Add("SERIALIZABLE");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.Serializable());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> Snapshot()
        {
            Statement.CurrentTable.TableHints.Add("SNAPSHOT");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.Snapshot());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> SpatialWindowMaxCells(int maxCells)
        {
            Statement.CurrentTable.TableHints.Add(string.Format("SPATIAL_WINDOW_MAX_CELLS = {0}", maxCells));
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.SpatialWindowMaxCells(0), new IntegerLiteral(maxCells));
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLock()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.TabLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> TabLockX()
        {
            Statement.CurrentTable.TableHints.Add("TABLOCKX");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.TabLockX());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> UpdateLock()
        {
            Statement.CurrentTable.TableHints.Add("UPDLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.UpdateLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> XLock()
        {
            Statement.CurrentTable.TableHints.Add("XLOCK");
            Statement.Append((ITableHintInJoin<TJoinEndType> input) => input.XLock());
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
