namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IUnpivotClauseAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias);
    }
}
