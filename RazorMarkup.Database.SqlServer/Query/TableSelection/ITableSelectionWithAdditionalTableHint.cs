namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint<TEndType> : ITableSelectionWithJoin<TEndType>
    {
        new ITableHint<TEndType> And();
    }
}
