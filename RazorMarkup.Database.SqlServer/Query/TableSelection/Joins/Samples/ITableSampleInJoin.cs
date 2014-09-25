using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Samples
{
    public interface ITableSampleInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithRepeatableInJoin<TJoinEndType> Percent(SqlFloat sampleNumber);

        ITableSelectionWithRepeatableInJoin<TJoinEndType> Rows(SqlBigInt sampleNumber);

        ITableSelectionWithRepeatableInJoin<TJoinEndType> Sample(SqlBigInt sampleNumber);
    }
}
