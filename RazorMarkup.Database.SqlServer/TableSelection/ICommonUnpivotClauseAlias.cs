namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonUnpivotClauseAlias<TTableSelectionWithJoin>: IHideObjectMethods
    {
        TTableSelectionWithJoin As(TableAlias tableAlias);
    }
}
