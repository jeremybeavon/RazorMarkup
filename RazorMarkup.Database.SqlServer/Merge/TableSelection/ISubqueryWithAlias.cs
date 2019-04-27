namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ISubqueryWithAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
