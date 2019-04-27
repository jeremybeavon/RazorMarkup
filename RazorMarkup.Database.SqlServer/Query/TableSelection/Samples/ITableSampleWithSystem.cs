namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSampleWithSystem<TEndType> : ITableSample<TEndType>
    {
        ITableSample<TEndType> System();
    }
}
