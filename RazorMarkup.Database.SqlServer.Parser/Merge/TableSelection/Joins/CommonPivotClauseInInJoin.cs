using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonPivotClauseInInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonPivotClauseInInJoin<
            TJoinEndType,
            IPivotClauseInInJoin<TJoinEndType>,
            IPivotClauseAliasInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonPivotClauseAliasInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
