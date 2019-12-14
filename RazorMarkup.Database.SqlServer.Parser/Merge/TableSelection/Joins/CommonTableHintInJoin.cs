using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonTableHintInJoin<TJoinEndType, TCommonJoinEndType> : 
        AbstractCommonTableHintInJoin<
            TJoinEndType,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithAdditionalTableHintInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
