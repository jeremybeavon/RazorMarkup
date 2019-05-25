namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IDerivedTableWithAliasInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoinInJoin<TJoinEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
