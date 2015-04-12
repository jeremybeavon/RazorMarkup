namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithTableHint : ITableSelectionWithJoin
    {
        ITableHint WithHint();
    }
}
