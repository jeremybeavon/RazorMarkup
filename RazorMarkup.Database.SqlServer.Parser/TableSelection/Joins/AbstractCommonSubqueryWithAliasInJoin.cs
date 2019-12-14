using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonSubqueryWithAliasInJoin<
        TJoinEndType,
        TSubqueryWithAlias,
        TTableSelectionWithJoin,
        TCommonJoinEndType,
        TCommonTableSelectionWithJoin> :
        AbstractCommonSubqueryWithAlias<
            TSubqueryWithAlias,
            TTableSelectionWithJoin,
            TCommonTableSelectionWithJoin>
        where TSubqueryWithAlias : ICommonSubqueryWithAlias<TTableSelectionWithJoin>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithJoin : ISource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin, new()
    {
    }
}
