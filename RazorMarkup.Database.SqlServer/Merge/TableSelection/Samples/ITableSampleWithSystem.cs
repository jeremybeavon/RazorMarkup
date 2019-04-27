namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples
{
    public interface ITableSampleWithSystem : ITableSample
    {
        ITableSample System();
    }
}
