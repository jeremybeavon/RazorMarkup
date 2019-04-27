namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples
{
    public interface ITableSampleWithSystemInJoin<TJoinEndType> : ITableSampleInJoin<TJoinEndType>
    {
        ITableSampleInJoin<TJoinEndType> System();
    }
}
