namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithAlias : ITableSelectionWithTableSample
    {
        ITableSelectionWithTableSample WithAlias(TableAlias tableAlias);
    }
}
