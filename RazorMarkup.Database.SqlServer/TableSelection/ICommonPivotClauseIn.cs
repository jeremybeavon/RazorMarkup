namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonPivotClauseIn<TPivotClauseAlias> : IHideObjectMethods
    {
        TPivotClauseAlias In(params ColumnName[] columns);
    }
}
