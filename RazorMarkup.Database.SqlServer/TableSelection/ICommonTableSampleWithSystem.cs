namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample> :
        ICommonTableSample<TTableSelectionWithRepeatable>
    {
        TTableSample System();
    }
}
