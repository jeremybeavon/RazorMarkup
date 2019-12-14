using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal class AbstractCommonTableSelectionWithRepeatableInJoin<
        TJoinEndType,
        TTableSelectionWithRepeatable,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableHint,
        TCommonTableSelectionWithTableHint> :
        AbstractCommonTableSelectionWithRepeatable<
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
            TCommonTableSelectionWithTableHint>
        where TTableSelectionWithRepeatable : ICommonTableSelectionWithRepeatableInJoin<TJoinEndType, TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint, TTableSelectionWithTableHint>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableHint : ISource<TTableHint>, ICommonTableHint, new()
        where TCommonTableSelectionWithTableHint : ISource<TTableSelectionWithTableHint>, ICommonTableSelectionWithTableHint, new()
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
