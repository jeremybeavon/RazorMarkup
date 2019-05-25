using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSourceInJoin<TJoinEndType> :
        ICommonTableSource<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            object,
            IDerivedTableWithAliasInJoin<TJoinEndType>>
    {
    }
}
