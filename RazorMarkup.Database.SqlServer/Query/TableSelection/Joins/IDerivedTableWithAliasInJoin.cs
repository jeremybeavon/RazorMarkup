using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IDerivedTableWithAliasInJoin<TJoinEndType> :
        ICommonDerivedTableWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>
    {
    }
}
