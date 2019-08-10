using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithRepeatable<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint> :
        ICommonTableSelectionWithTableHint<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
        TTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }
}
