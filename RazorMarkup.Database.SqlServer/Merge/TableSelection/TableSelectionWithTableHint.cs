using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableHint : TableSelectionWithJoin,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public new static ITableSelectionWithTableHint Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableHint(statement);
        }

        public ITableHint WithHint()
        {
            Statement.Append((ITableSelectionWithTableHint input) => input.WithHint());
            return new TableHint(Statement);
        }
    }
}
