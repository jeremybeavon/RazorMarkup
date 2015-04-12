namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithTableHint<TEndType> : ITableSelectionWithJoin<TEndType>
    {
        ITableHint<TEndType> WithHint();
    }
}
