namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonUnpivotClauseIn
    {
        ICommonUnpivotClauseAlias In(params ColumnName[] columnNames);
    }
}
