using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSource<TEndType> : ICommonTableSource<
        ITableSelectionWithAlias<TEndType>,
        ISubqueryWithAlias<TEndType>,
        IDerivedTableWithAlias<TEndType>>
    {
    }
}
