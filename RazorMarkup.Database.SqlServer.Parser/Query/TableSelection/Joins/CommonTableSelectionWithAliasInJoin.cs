using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithAliasInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonTableSelectionWithAliasInJoin<
            TJoinEndType,
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>, CommonTableSelectionWithJoinInJoin<TJoinEndType, TCommonJoinEndType>>,
            CommonTableSourceInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonPivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonUnpivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableHintInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableSampleWithSystemInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableSelectionWithTableSampleInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
