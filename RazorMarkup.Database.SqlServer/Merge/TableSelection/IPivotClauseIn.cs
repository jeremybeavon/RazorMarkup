namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IPivotClauseIn : IHideObjectMethods
    {
        IPivotClauseAlias In(params ColumnName[] columns);
    }
}
