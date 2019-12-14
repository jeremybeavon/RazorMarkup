using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;


namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithAdditionalTableHintInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonTableSelectionWithAdditionalTableHintInJoin<
            TJoinEndType,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            IAdditionalTableHintInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>, CommonTableSelectionWithJoinInJoin<TJoinEndType, TCommonJoinEndType>>,
            CommonTableSourceInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonPivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonUnpivotClauseInJoin<TJoinEndType, TCommonJoinEndType>,
            AdditionalCommonTableHintInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
