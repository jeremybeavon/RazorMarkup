using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectColumn<TEndType> : SelectClauseAnd<TEndType>, ISelectColumn<TEndType>
    {
        public SelectColumn(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseAnd<TEndType> As(ColumnAlias columnAlias)
        {
            Statement.Columns[Statement.Columns.Count - 1].Alias = columnAlias.ToSqlString();
            Statement.Append((ISelectColumn<TEndType> input) => input.As(null), columnAlias);
            return this;
        }
    }
}
