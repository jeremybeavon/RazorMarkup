using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableHintInJoin<TJoinEndType> :
        CommonTableHint<TJoinEndType, ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>,
        ITableHintInJoin<TJoinEndType>
    {
        public TableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure, TableSelectionFactories.CreateTableSelectionWithAdditionalTableHint)
        {
        }
    }
}
