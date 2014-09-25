namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Samples
{
    public interface ITableSampleWithSystemInJoin<TJoinEndType> : ITableSampleInJoin<TJoinEndType>
    {
        ITableSampleInJoin<TJoinEndType> System();
    }
}
