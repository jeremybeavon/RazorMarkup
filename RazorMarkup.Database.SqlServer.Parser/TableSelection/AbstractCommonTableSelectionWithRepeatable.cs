using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal class AbstractCommonTableSelectionWithRepeatable<
        TTableSelectionWithRepeatable,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSelectionWithTableHint> :
        AbstractCommonTableSelectionWithTableHint<
            TTableSelectionWithRepeatable,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TCommonTableSourceInJoin,
            TCommonTableSource,
            TCommonPivotClause,
            TCommonUnpivotClause,
            TCommonTableHint>,
        ICommonTableSelectionWithRepeatable
        where TTableSelectionWithRepeatable : ICommonTableSelectionWithRepeatable<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSelectionWithTableHint>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSelectionWithTableHint : ISource<TTableSelectionWithTableHint>, ICommonTableSelectionWithTableHint, new()
    {
        public ICommonTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            return new TCommonTableSelectionWithTableHint()
            {
                Source = Source.WithRepeatSeed(repeatSeed)
            };
        }
    }
}
