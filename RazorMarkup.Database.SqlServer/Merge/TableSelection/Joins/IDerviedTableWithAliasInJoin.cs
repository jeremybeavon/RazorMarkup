namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IDerviedTableWithAliasInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoinInJoin<TJoinEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
