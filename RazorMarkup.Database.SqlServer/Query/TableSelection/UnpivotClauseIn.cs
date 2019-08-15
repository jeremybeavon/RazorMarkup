using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class UnpivotClauseIn<TEndType> :
        CommonUnpivotClauseIn<IUnpivotClauseAlias<TEndType>>,
        IUnpivotClauseIn<TEndType>
    {
        public UnpivotClauseIn(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, builder => new UnpivotClauseAlias<TEndType>(builder, endClosure))
        {
        }
    }
}
