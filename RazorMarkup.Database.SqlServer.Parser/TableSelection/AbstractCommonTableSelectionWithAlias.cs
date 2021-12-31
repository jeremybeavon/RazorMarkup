using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal class AbstractCommonTableSelectionWithAlias<
        TTableSelectionWithAlias,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSampleWithSystem,
        TCommonTableSelectionWithTableSample> :
        AbstractCommonTableSelectionWithTableSample<
            TTableSelectionWithAlias,
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
            TCommonTableSampleWithSystem>,
        ICommonTableSelectionWithAlias
        where TTableSelectionWithAlias : ICommonTableSelectionWithAlias<TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem, TTableSelectionWithTableSample>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSampleWithSystem : ISource<TTableSampleWithSystem>, ICommonTableSampleWithSystem, new()
        where TCommonTableSelectionWithTableSample : ISource<TTableSelectionWithTableSample>, ICommonTableSelectionWithTableSample, new()
    {
        public ICommonTableSelectionWithTableSample As(TableAlias tableAlias)
        {
            return new TCommonTableSelectionWithTableSample()
            {
                Source = Source.As(tableAlias)
            };
        }
    }
}
