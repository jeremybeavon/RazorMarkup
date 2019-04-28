namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSelectionWithAlias : ITableSelectionWithTableSample
    {
        ITableSelectionWithTableSample As(TableAlias tableAlias);
    }
}
