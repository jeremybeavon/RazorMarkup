using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSample : IHideObjectMethods
    {
        ITableSelectionWithRepeatable Percent(SqlFloat sampleNumber);

        ITableSelectionWithRepeatable Rows(SqlBigInt sampleNumber);

        ITableSelectionWithRepeatable Sample(SqlBigInt sampleNumber);
    }
}
