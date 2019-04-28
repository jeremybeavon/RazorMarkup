namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IPivotClauseAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias);
    }
}
