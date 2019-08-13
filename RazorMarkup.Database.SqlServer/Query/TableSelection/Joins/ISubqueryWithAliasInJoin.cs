using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ISubqueryWithAliasInJoin<TJoinEndType> :
        ICommonSubqueryWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>
    {
    }
}
