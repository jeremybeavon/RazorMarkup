using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableHintInJoin<TJoinEndType> :
        CommonTableHint<ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>,
        ITableHintInJoin<TJoinEndType>
    {
        public TableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
