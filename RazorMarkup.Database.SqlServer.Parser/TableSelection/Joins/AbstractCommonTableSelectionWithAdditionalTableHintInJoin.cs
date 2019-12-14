using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableSelectionWithAdditionalTableHintInJoin<
        TJoinEndType,
        TTableSelectionWithAdditionalTableHint,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonAdditionalTableHint> :
        AbstractCommonTableSelectionWithAdditionalTableHint<
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
            TCommonAdditionalTableHint>
        where TTableSelectionWithAdditionalTableHint : ICommonTableSelectionWithAdditionalTableHintInJoin<TJoinEndType, TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TAdditionalTableHint>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonAdditionalTableHint : ISource<TAdditionalTableHint>, ICommonAdditionalTableHint, new()
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
