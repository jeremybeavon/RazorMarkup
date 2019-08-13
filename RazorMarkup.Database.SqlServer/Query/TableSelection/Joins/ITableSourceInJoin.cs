using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSourceInJoin<TJoinEndType> :
        ICommonTableSource<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>>
    {
    }
}
