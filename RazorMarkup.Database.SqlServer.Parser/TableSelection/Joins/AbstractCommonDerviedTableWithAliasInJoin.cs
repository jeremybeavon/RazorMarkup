using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonDerviedTableWithAliasInJoin<
        TJoinEndType,
        TDerivedTableWithAlias,
        TTableSelectionWithJoin,
        TCommonJoinEndType,
        TCommonTableSelectionWithJoin> :
        AbstractCommonDerviedTableWithAlias<
            TDerivedTableWithAlias,
            TTableSelectionWithJoin,
            TCommonTableSelectionWithJoin>
        where TDerivedTableWithAlias : ICommonDerivedTableWithAlias<TTableSelectionWithJoin>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithJoin : ISource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin, new()
    {
    }
}
