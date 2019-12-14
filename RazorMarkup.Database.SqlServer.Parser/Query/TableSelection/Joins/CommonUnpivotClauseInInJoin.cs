using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
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
