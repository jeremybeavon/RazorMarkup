namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ISubqueryWithAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
