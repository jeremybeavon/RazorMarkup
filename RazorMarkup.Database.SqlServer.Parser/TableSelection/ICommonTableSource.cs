namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSource
    {
        ICommonTableSelectionWithAlias Table(TableName tableName);

        ICommonTableSelectionWithAlias View(ViewName viewName);
    }
}
