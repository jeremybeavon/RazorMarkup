namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSampleWithSystem : ITableSample
    {
        ITableSample System();
    }
}
