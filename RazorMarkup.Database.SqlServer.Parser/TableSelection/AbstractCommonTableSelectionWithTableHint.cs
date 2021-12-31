using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal class AbstractCommonTableSelectionWithTableHint<
        TTableSelectionWithTableHint,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint> :
        AbstractCommonTableSelectionWithJoin<
            TTableSelectionWithTableHint,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSourceInJoin,
            TCommonTableSource,
            TCommonPivotClause,
            TCommonUnpivotClause>,
        ICommonTableSelectionWithTableHint
        where TTableSelectionWithTableHint : ICommonTableSelectionWithTableHint<TTableSource, TPivotClause, TUnpivotClause, TTableHint>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
    {
        public ICommonTableHint WithHint()
        {
            return new TCommonTableHint()
            {
                Source = Source.WithHint()
            };
        }
    }
}
