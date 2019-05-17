namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonDerivedTableWithAlias<TTableSelectionWithJoin> : IHideObjectMethods
    {
        TTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
