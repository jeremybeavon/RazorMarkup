using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithRepeatable<
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint> :
        ICommonTableSelectionWithTableHint<TTableSource, TPivotClause, TUnpivotClause, TTableHint>
    {
        TTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }

    public interface ICommonTableSelectionWithRepeatable<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint> :
        ICommonTableSelectionWithRepeatable<TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSelectionWithTableHint>
    {
    }
}
