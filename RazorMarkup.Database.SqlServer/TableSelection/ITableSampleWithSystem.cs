namespace RazorMarkup.Database.SqlServer.TableSelection.Samples
{
    public interface ITableSampleWithSystem : ITableSample
    {
        ITableSample System();
    }
}
