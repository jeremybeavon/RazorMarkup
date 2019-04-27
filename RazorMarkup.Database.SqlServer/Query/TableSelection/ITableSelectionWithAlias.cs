namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithAlias<TEndType> : ITableSelectionWithTableSample<TEndType>
    {
        ITableSelectionWithTableSample<TEndType> As(TableAlias tableAlias);
    }
}
