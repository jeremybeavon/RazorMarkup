using RazorMarkup.Database.SqlServer.Query.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithTableSample<TEndType> : ITableSelectionWithTableHint<TEndType>
    {
        ITableSampleWithSystem<TEndType> TableSample();
    }
}
