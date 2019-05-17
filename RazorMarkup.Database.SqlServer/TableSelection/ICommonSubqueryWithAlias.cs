namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonSubqueryWithAlias<TTableSelectionWithJoin> : IHideObjectMethods
    {
        TTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
