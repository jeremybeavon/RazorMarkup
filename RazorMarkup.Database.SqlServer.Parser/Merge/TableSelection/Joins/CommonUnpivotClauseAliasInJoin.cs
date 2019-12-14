using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal sealed class CommonUnpivotClauseAliasInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonUnpivotClauseAliasInJoin<
            TJoinEndType,
            IUnpivotClauseAliasInJoin<TJoinEndType>,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>, CommonTableSelectionWithJoinInJoin<TJoinEndType, TCommonJoinEndType>>,
            CommonTableSourceInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonPivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonUnpivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableSelectionWithJoinInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
