using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
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
