using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeUsing : AbstractStatement<MergeStatementBuilder>, IMergeUsing
    {
        public MergeUsing(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public ITableSource Using()
        {
            MergeFromClauseBuilder fromClause = new(ExpressionBuilder, Statement);
            Statement.UsingClause = fromClause;
            Statement.Append((IMergeUsing input) => input.Using());
            return new TableSource(fromClause);
        }
    }
}
