namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSelectionWithTableHint : ITableSelectionWithJoin
    {
        ITableHint WithHint();
    }
}
