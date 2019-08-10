namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonPivotClauseAlias<TTableSelectionWithJoin> : IHideObjectMethods
    {
        TTableSelectionWithJoin As(TableAlias tableAlias);
    }
}
