using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractAdditionalCommonTableHintInJoin<
        TJoinEndType,
        TAdditionalTableHint,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TTableSelectionWithAdditionalTableHint,
        TCommonJoinEndType,
        TCommonTableSelectionWithAlias,
        TCommonSubqueryWithAlias,
        TCommonDerivedTableWithAlias,
        TCommonTableSelectionWithAdditionalTableHint> :
        AbstractAdditionalCommonTableHint<
            TAdditionalTableHint,
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TTableSelectionWithAdditionalTableHint,
            TCommonTableSelectionWithAlias,
            TCommonSubqueryWithAlias,
            TCommonDerivedTableWithAlias,
            TCommonTableSelectionWithAdditionalTableHint>
        where TAdditionalTableHint : IAdditionalCommonTableHint<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias, TTableSelectionWithAdditionalTableHint>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithAlias : ISource<TTableSelectionWithAlias>, ICommonTableSelectionWithAlias, new()
        where TCommonSubqueryWithAlias : ISource<TSubqueryWithAlias>, ICommonSubqueryWithAlias, new()
        where TCommonDerivedTableWithAlias : ISource<TDerivedTableWithAlias>, ICommonDerivedTableWithAlias, new()
        where TCommonTableSelectionWithAdditionalTableHint : ISource<TTableSelectionWithAdditionalTableHint>, ICommonTableSelectionWithAdditionalTableHint, new()
    {
    }
}
