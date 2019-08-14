using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IDerivedTableWithAliasInJoin<TJoinEndType> :
        ICommonDerivedTableWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>
    {
    }
}
