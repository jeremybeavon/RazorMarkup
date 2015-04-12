namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClauseAlias<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias);
    }
}
