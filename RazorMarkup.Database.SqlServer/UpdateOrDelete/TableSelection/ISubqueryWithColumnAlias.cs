namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ISubqueryWithColumnAlias : ISubqueryWithJoin
    {
        ITableSelectionWithJoin WithColumnAlias(params ColumnAlias[] columnAlias);
    }
}
