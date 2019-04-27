namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint : ITableSelectionWithJoin
    {
        ITableHint And();
    }
}
