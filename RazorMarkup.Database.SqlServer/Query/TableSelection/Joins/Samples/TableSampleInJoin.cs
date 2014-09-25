using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Samples
{
    internal class TableSampleInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSampleInJoin<TJoinEndType>
    {
        public TableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Percent(SqlFloat sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Rows(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = false;
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Sample(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
