namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ISubqueryWithAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
