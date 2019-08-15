namespace RazorMarkup.Database.SqlServer.SetClauses
{
    public interface ICommonSetClause<TSetColumn, TSetVariable> : IHideObjectMethods
    {
        TSetColumn Set(ColumnName columnName);

        TSetVariable Set(VariableName variableName);
    }
}
