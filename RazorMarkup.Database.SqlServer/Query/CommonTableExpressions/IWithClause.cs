namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface IWithClause : IHideObjectMethods
    {
        ICommonTableExpression With(TableAlias tableName, params ColumnAlias[] columnNames);
    }
}
