using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal class AbstractCommonTableSelectionWithTableSample<
        TTableSelectionWithTableSample,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSampleWithSystem> :
        AbstractCommonTableSelectionWithTableHint<
            TTableSelectionWithTableSample,
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
        ICommonTableSelectionWithTableSample
        where TTableSelectionWithTableSample : ICommonTableSelectionWithTableSample<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSampleWithSystem : ISource<TTableSampleWithSystem>, ICommonTableSampleWithSystem, new()
    {
        public ICommonTableSampleWithSystem TableSample()
        {
            return new TCommonTableSampleWithSystem()
            {
                Source = Source.TableSample()
            };
        }
    }
}
