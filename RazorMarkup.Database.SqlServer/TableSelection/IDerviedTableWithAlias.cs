namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IDerviedTableWithAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
