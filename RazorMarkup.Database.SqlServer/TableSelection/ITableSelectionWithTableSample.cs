using RazorMarkup.Database.SqlServer.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSelectionWithTableSample : ITableSelectionWithTableHint
    {
        ITableSampleWithSystem TableSample();
    }
}
