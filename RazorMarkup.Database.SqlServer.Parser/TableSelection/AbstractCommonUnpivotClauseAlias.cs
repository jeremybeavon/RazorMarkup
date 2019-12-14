using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonUnpivotClauseAlias<
        TUnpivotClauseAlias,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableSelectionWithJoin> :
        AbstractCommonTableSelectionWithJoin<
            TUnpivotClauseAlias,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSourceInJoin,
            TCommonTableSource,
            TCommonPivotClause,
            TCommonUnpivotClause>,
        ICommonUnpivotClauseAlias
        where TUnpivotClauseAlias : ICommonUnpivotClauseAlias<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableSelectionWithJoin : ISource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin, new()
    {
        public ICommonTableSelectionWithJoin As(TableAlias tableAlias)
        {
            return new TCommonTableSelectionWithJoin()
            {
                Source = Source.As(tableAlias)
            };
        }
    }
}
