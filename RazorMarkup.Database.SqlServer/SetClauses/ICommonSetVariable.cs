namespace RazorMarkup.Database.SqlServer.SetClauses
{
    public interface ICommonSetVariable<TSetClauseAnd, TSetValue> : ICommonSetValue<TSetClauseAnd>
    {
        TSetValue Equals(ColumnName columnName);
    }
}
