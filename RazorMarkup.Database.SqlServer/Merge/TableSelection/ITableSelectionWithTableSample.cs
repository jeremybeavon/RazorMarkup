using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithTableSample : ITableSelectionWithTableHint
    {
        ITableSampleWithSystem TableSample();
    }
}
