namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSource : IHideObjectMethods
    {
        ITableSelectionWithAlias Table(TableName tableName);

        ITableSelectionWithAlias View(ViewName viewName);

        //ISubquery<ISubqueryWithAlias> Subquery();
    }
}
