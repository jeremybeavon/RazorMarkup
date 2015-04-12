namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonPivotClause
    {
        ICommonPivotClauseIn For(ColumnName columnName);
    }
}
