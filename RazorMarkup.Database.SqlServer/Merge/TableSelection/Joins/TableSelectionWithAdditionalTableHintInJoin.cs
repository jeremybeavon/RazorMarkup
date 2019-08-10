using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal sealed class TableSelectionWithAdditionalTableHintInJoin<TJoinEndType> :
        TableSelectionWithJoinInJoin<TJoinEndType>,
        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithAdditionalTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        IAdditionalTableHint ICommonTableSelectionWithAdditionalTableHint<ITableSelectionWithJoinInJoin<TJoinEndType>, ITableSourceInJoin<TJoinEndType>, object, object, IAdditionalTableHint>.And()
        {
            throw new global::System.NotImplementedException();
        }
    }
}
