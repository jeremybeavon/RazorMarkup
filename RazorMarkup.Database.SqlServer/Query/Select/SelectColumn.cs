using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectColumn<TEndType> : SelectClauseWithInto<TEndType>, ISelectColumn<TEndType>
    {
        public SelectColumn(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithInto<TEndType> WithAlias(ColumnAlias columnAlias)
        {
            Statement.Columns[Statement.Columns.Count - 1].Alias = columnAlias.ToSqlString();
            Statement.Append((ISelectColumn<TEndType> input) => input.WithAlias(null), columnAlias);
            return this;
        }
    }
}
