namespace RazorMarkup.Database.SqlServer.TableSelection.Joins.Samples
{
    public interface ITableSampleWithSystemInJoin<TJoinEndType> : ITableSampleInJoin<TJoinEndType>
    {
        ITableSampleInJoin<TJoinEndType> System();
    }
}
