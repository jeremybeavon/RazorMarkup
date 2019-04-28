namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint : ITableSelectionWithJoin
    {
        new ITableHint And();
    }
}
