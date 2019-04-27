using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithTableSampleInJoin<TJoinEndType> :
        TableSelectionWithTableHintInJoin<TJoinEndType>,
        ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        public TableSelectionWithTableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSampleWithSystemInJoin<TJoinEndType> TableSample()
        {
            Statement.Append((ITableSelectionWithTableSampleInJoin<TJoinEndType> input) => input.TableSample());
            return new TableSampleWithSystemInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
