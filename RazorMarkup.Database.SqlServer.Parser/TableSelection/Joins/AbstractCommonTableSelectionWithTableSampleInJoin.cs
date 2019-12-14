using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal class AbstractCommonTableSelectionWithTableSampleInJoin<
        TJoinEndType,
        TTableSelectionWithTableSample,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSampleWithSystem> :
        AbstractCommonTableSelectionWithTableSample<
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
            TCommonTableSampleWithSystem>
        where TTableSelectionWithTableSample : ICommonTableSelectionWithTableSampleInJoin<TJoinEndType,TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSampleWithSystem>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSampleWithSystem : ISource<TTableSampleWithSystem>, ICommonTableSampleWithSystem, new()
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
