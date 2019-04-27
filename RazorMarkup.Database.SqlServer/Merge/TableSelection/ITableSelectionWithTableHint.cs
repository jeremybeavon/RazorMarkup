namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithTableHint : ITableSelectionWithJoin
    {
        ITableHint WithHint();
    }
}
