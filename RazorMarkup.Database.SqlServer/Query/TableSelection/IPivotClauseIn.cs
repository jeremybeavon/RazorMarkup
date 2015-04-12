namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClauseIn<TEndType> : IHideObjectMethods
    {
        IPivotClauseAlias<TEndType> In(params ColumnName[] columns);
    }
}
