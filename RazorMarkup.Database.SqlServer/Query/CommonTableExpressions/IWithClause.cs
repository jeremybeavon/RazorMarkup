namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IWithClause<TEndType> : IHideObjectMethods
    {
        ICommonTableExpression<TEndType> With(TableAlias tableName, params ColumnAlias[] columnNames);
    }
}
