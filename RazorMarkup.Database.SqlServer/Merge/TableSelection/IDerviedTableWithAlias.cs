namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IDerviedTableWithAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
