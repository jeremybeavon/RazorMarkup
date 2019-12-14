using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonUnpivotClauseInInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonUnpivotClauseInInJoin<
            TJoinEndType,
            IUnpivotClauseInInJoin<TJoinEndType>,
            IUnpivotClauseAliasInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonUnpivotClauseAliasInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
