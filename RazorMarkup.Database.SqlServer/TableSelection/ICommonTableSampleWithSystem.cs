namespace RazorMarkup.Database.SqlServer.TableSelection.Samples
{
    public interface ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample> :
        ICommonTableSample<TTableSelectionWithRepeatable>
    {
        TTableSample System();
    }
}
