using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonUnpivotClauseInJoin<
        TJoinEndType,
        TUnpivotClause,
        TUnpivotClauseIn,
        TCommonJoinEndType,
        TCommonUnpivotClauseIn> :
        AbstractCommonUnpivotClause<
            TUnpivotClause,
            TUnpivotClauseIn,
            TCommonUnpivotClauseIn>
        where TUnpivotClause : ICommonUnpivotClause<TUnpivotClauseIn>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonUnpivotClauseIn : ISource<TUnpivotClauseIn>, ICommonUnpivotClauseIn, new()
    {
    }
}
