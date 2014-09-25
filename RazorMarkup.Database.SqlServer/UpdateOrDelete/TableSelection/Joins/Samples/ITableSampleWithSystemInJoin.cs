namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples
{
    public interface ITableSampleWithSystemInJoin<TJoinEndType> : ITableSampleInJoin<TJoinEndType>
    {
        ITableSampleInJoin<TJoinEndType> System();
    }
}
