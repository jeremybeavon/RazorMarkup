using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonUnpivotClauseInInJoin<
        TJoinEndType,
        TUnpivotClauseIn,
        TUnpivotClauseAlias,
        TCommonJoinEndType,
        TCommonUnpivotClauseAlias> :
        AbstractCommonUnpivotClauseIn<
            TUnpivotClauseIn,
            TUnpivotClauseAlias,
            TCommonUnpivotClauseAlias>
        where TUnpivotClauseIn : ICommonUnpivotClauseIn<TUnpivotClauseAlias>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonUnpivotClauseAlias : ISource<TUnpivotClauseAlias>, ICommonUnpivotClauseAlias, new()
    {
    }
}
