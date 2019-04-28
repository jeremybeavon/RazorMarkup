namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface IPivotClauseIn : IHideObjectMethods
    {
        IPivotClauseAlias In(params ColumnName[] columns);
    }
}
