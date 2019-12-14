using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal class AbstractCommonTableSelectionWithAliasInJoin<
        TJoinEndType,
        TTableSelectionWithAlias,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSampleWithSystem,
        TCommonTableSelectionWithTableSample> :
        AbstractCommonTableSelectionWithAlias<
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
            TCommonTableSelectionWithTableSample>
        where TTableSelectionWithAlias : ICommonTableSelectionWithAliasInJoin<TJoinEndType, TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem, TTableSelectionWithTableSample>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSampleWithSystem : ISource<TTableSampleWithSystem>, ICommonTableSampleWithSystem, new()
        where TCommonTableSelectionWithTableSample : ISource<TTableSelectionWithTableSample>, ICommonTableSelectionWithTableSample, new()
    {
        public override ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression)
        {
            return new TCommonJoinEndType()
            {
                Source = Source.On(expression)
            };
        }
    }
}
