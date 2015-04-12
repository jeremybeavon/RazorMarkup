namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClauseAlias<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias);
    }
}
