using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSampleWithSystem : ICommonTableSampleWithSystem<ITableSelectionWithRepeatable, ITableSample>
    {
    }
}
