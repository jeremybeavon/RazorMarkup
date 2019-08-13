using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSample<TEndType> : ICommonTableSample<ITableSelectionWithRepeatable<TEndType>>
    {
    }
}
