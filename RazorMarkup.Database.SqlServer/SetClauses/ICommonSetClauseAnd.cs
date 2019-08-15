namespace RazorMarkup.Database.SqlServer.SetClauses
{
    public interface ICommonSetClauseAnd<TSetColumn, TSetVariable> : IHideObjectMethods
    {
        TSetColumn And(ColumnName columnName);

        TSetVariable And(VariableName variableName);
    }
}
