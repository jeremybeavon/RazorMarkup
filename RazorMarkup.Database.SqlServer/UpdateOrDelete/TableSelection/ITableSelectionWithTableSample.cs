using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithTableSample : ITableSelectionWithTableHint
    {
        ITableSample WithTableSample();
    }
}
