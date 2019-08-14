using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class PivotClauseIn :
        CommonPivotClauseIn<IPivotClauseAlias>,
        IPivotClauseIn
    {
        public PivotClauseIn(FromClauseBuilder statement)
            : base(statement, PivotClauseAlias.Create)
        {
        }

        public static IPivotClauseIn Create(FromClauseBuilder statement)
        {
            return new PivotClauseIn(statement);
        }
    }
}
