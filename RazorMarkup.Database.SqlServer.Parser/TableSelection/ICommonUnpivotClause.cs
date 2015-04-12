namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonUnpivotClause
    {
        ICommonUnpivotClauseIn For(ColumnName columnName);
    }
}
