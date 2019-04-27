namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithAlias : ITableSelectionWithTableSample
    {
        ITableSelectionWithTableSample As(TableAlias tableAlias);
    }
}
