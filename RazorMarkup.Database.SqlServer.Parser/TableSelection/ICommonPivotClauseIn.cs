namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonPivotClauseIn
    {
        ICommonPivotClauseAlias In(params ColumnName[] columns);
    }
}
