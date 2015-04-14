namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonSubqueryWithAlias
    {
        ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
