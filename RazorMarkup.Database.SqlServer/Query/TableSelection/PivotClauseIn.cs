using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class PivotClauseIn<TEndType> :
        CommonPivotClauseIn<IPivotClauseAlias<TEndType>>,
        IPivotClauseIn<TEndType>
    {
        public PivotClauseIn(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, builder => new PivotClauseAlias<TEndType>(builder, endClosure))
        {
        }
    }
}
