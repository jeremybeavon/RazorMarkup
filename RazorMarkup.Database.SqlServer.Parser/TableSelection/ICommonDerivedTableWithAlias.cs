namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonDerivedTableWithAlias
    {
        ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
