using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableSelectionWithJoinInJoin<
        TJoinEndType,
        TTableSelectionWithJoin,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause> :
        AbstractCommonTableSelectionWithJoin<
            TTableSelectionWithJoin,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSourceInJoin,
            TCommonTableSource,
            TCommonPivotClause,
            TCommonUnpivotClause>
        where TTableSelectionWithJoin : ICommonTableSelectionWithJoinInJoin<TJoinEndType, TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
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
