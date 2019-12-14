using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonPivotClauseInInJoin<
        TJoinEndType,
        TPivotClauseIn,
        TPivotClauseAlias,
        TCommonJoinEndType,
        TCommonPivotClauseAlias> :
        AbstractCommonPivotClauseIn<
            TPivotClauseIn,
            TPivotClauseAlias,
            TCommonPivotClauseAlias>
        where TPivotClauseIn : ICommonPivotClauseIn<TPivotClauseAlias>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonPivotClauseAlias : ISource<TPivotClauseAlias>, ICommonPivotClauseAlias, new()
    {
    }
}
