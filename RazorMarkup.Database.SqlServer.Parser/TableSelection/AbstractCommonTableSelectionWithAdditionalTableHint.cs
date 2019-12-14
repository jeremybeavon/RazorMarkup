using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonTableSelectionWithAdditionalTableHint<
        TTableSelectionWithAdditionalTableHint,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonAdditionalTableHint> :
        AbstractCommonTableSelectionWithJoin<
            TTableSelectionWithAdditionalTableHint,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSourceInJoin,
            TCommonTableSource,
            TCommonPivotClause,
            TCommonUnpivotClause>,
        ICommonTableSelectionWithAdditionalTableHint
        where TTableSelectionWithAdditionalTableHint : ICommonTableSelectionWithAdditionalTableHint<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TAdditionalTableHint>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonAdditionalTableHint : ISource<TAdditionalTableHint>, ICommonAdditionalTableHint, new()
    {
        public new ICommonAdditionalTableHint And()
        {
            return new TCommonAdditionalTableHint()
            {
                Source = Source.And()
            };
        }
    }
}
