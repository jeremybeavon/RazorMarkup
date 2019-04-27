namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IPivotClauseAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias);
    }
}
