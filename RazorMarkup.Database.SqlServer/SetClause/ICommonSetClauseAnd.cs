namespace RazorMarkup.Database.SqlServer.SetClause
{
    public interface ICommonSetClauseAnd<TSetColumn, TSetVariable> : IHideObjectMethods
    {
        TSetColumn And(ColumnName columnName);

        TSetVariable And(VariableName variableName);
    }
}
