using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class UnpivotClause : CommonUnpivotClause<IUnpivotClauseIn>, IUnpivotClause
    {
        public UnpivotClause(FromClauseBuilder statement)
            : base(statement, UnpivotClauseIn.Create)
        {
        }

        public static IUnpivotClause Create(FromClauseBuilder statement)
        {
            return new UnpivotClause(statement);
        }
    }
}
