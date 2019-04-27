namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IUnpivotClauseAlias : IHideObjectMethods
    {
        ITableSelectionWithJoin As(TableAlias tableAlias);
    }
}
