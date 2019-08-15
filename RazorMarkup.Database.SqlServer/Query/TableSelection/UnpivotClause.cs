using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class UnpivotClause<TEndType> :
        CommonUnpivotClause<IUnpivotClauseIn<TEndType>>,
        IUnpivotClause<TEndType>
    {
        public UnpivotClause(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, builder => new UnpivotClauseIn<TEndType>(builder, endClosure))
        {
        }
    }
}
