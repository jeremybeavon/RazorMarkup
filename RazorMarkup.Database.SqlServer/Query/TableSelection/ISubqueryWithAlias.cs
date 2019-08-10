using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ISubqueryWithAlias<TEndType> : ICommonSubqueryWithAlias<ITableSelectionWithJoin<TEndType>>
    {
    }
}
