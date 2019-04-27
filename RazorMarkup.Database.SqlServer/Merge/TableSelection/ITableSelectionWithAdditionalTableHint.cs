namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint : ITableSelectionWithJoin
    {
        new ITableHint And();
    }
}
