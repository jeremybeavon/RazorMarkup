using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class PivotClause<TEndType> :
        CommonPivotClause<IPivotClauseIn<TEndType>>,
        IPivotClause<TEndType>
    {
        public PivotClause(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, new TableSelectionFactory<TEndType>(endClosure).CreatePivotClauseIn)
        {
        }
    }
}
