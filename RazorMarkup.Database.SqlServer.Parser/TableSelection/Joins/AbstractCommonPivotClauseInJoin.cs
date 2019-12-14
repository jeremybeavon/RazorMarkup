using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonPivotClauseInJoin<
        TJoinEndType,
        TPivotClause,
        TPivotClauseIn,
        TCommonJoinEndType,
        TCommonPivotClauseIn> :
        AbstractCommonPivotClause<
            TPivotClause,
            TPivotClauseIn,
            TCommonPivotClauseIn>
        where TPivotClause : ICommonPivotClause<TPivotClauseIn>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonPivotClauseIn : ISource<TPivotClauseIn>, ICommonPivotClauseIn, new()
    {
    }
}
