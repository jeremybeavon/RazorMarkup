namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ISubqueryWithAlias<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
