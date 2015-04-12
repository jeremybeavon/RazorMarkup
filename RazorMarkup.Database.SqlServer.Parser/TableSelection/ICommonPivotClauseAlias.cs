namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonPivotClauseAlias
    {
        ICommonTableSelectionWithJoin As(TableAlias tableAlias);
    }
}
