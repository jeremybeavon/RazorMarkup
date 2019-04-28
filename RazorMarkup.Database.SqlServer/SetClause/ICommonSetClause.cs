namespace RazorMarkup.Database.SqlServer.SetClause
{
    public interface ICommonSetClause<TSetColumn, TSetVariable> : IHideObjectMethods
    {
        TSetColumn Set(ColumnName columnName);

        TSetVariable Set(VariableName variableName);
    }
}
