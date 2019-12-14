using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableHintInJoin<
        TJoinEndType,
        TTableHint,
        TTableSelectionWithAdditionalTableHint,
        TCommonJoinEndType,
        TCommonTableSelectionWithAdditionalTableHint> :
        AbstractCommonTableHint<
            TTableHint,
            TTableSelectionWithAdditionalTableHint,
            TCommonTableSelectionWithAdditionalTableHint>
        where TTableHint : ICommonTableHint<TTableSelectionWithAdditionalTableHint>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithAdditionalTableHint : ISource<TTableSelectionWithAdditionalTableHint>, ICommonTableSelectionWithAdditionalTableHint, new()
    {
    }
}
