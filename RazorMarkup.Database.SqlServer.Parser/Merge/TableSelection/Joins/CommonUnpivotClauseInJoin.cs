using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonUnpivotClauseInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonUnpivotClause<
            IUnpivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInInJoin<TJoinEndType>,
            CommonUnpivotClauseInInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
