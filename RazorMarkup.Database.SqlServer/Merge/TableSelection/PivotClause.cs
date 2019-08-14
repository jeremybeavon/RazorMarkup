using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class PivotClause : CommonPivotClause<IPivotClauseIn>, IPivotClause
    {
        public PivotClause(FromClauseBuilder statement)
            : base(statement, PivotClauseIn.Create)
        {
        }

        public static IPivotClause Create(FromClauseBuilder statement)
        {
            return new PivotClause(statement);
        }
    }
}
