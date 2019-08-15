using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class UnpivotClauseIn : CommonUnpivotClauseIn<IUnpivotClauseAlias>, IUnpivotClauseIn
    {
        public UnpivotClauseIn(FromClauseBuilder statement)
            : base(statement, UnpivotClauseAlias.Create)
        {
        }

        public static IUnpivotClauseIn Create(FromClauseBuilder statement)
        {
            return new UnpivotClauseIn(statement);
        }
    }
}
