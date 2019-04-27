using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClauseWithInto<TEndType> : SelectClauseWithFrom<TEndType>, ISelectClauseWithInto<TEndType>
    {
        public SelectClauseWithInto(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithFrom<TEndType> Into(TableName tableName)
        {
            Statement.IntoTable = tableName.ToSqlString();
            Statement.Append((ISelectClauseWithInto<TEndType> input) => input.Into(null), tableName);
            return this;
        }
    }
}
