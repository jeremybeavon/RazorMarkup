using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSampleWithSystem<TEndType> :
        ICommonTableSampleWithSystem<ITableSelectionWithRepeatable<TEndType>, ITableSample<TEndType>>
    {
    }
}
