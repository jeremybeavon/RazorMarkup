namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonUnpivotClauseAlias
    {
        ICommonTableSelectionWithJoin As(TableAlias tableAlias);
    }
}
