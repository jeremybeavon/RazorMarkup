using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class AdditionalCommonTableHintInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractAdditionalCommonTableHintInJoin<
            TJoinEndType,
            IAdditionalTableHintInJoin<TJoinEndType>,
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithAliasInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonSubqueryWithAliasInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonDerivedTableWithAliasInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableSelectionWithAdditionalTableHintInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
