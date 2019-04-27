namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IDerviedTableWithAliasInJoin<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoinInJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
