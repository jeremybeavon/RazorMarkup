using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType> :
        //ICommonTableSelectionWithTableSourceInJoin<ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>>,
        ICommonTableSelectionWithAliasInJoin<
            TJoinEndType,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>>
    {
    }
}
