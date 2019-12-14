using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableSourceInJoin<
        TJoinEndType,
        TTableSource,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TCommonJoinEndType,
        TCommonTableSelectionWithAlias,
        TCommonSubqueryWithAlias,
        TCommonDerivedTableWithAlias> : 
        AbstractCommonTableSource<
            TTableSource,
            TTableSelectionWithAlias,
            TSubqueryWithAlias,
            TDerivedTableWithAlias,
            TCommonTableSelectionWithAlias,
            TCommonSubqueryWithAlias,
            TCommonDerivedTableWithAlias>
        where TTableSource : ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithAlias : ISource<TTableSelectionWithAlias>, ICommonTableSelectionWithAlias, new()
        where TCommonSubqueryWithAlias : ISource<TSubqueryWithAlias>, ICommonSubqueryWithAlias, new()
        where TCommonDerivedTableWithAlias : ISource<TDerivedTableWithAlias>, ICommonDerivedTableWithAlias, new()
    {
    }
}
