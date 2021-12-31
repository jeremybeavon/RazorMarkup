using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal sealed class CommonUnpivotClauseAliasInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonUnpivotClauseAliasInJoin<
            TJoinEndType,
            IUnpivotClauseAliasInJoin<TJoinEndType>,
            ITableSourceInJoinWithTableSelectionInJoin<TJoinEndType>,
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
