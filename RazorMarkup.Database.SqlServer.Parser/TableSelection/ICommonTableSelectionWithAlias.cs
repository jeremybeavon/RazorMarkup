namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithAlias : ICommonTableSelectionWithTableSample
    {
        ICommonTableSelectionWithTableSample WithAlias(TableAlias tableAlias);
    }
}
