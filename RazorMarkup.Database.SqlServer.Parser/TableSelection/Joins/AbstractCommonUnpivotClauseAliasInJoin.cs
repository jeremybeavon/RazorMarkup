using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonUnpivotClauseAliasInJoin<
        TJoinEndType,
        TUnpivotClauseAlias,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonJoinEndType,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause,
        TCommonTableSelectionWithJoin> :
        AbstractCommonUnpivotClauseAlias<
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
            TCommonTableSelectionWithJoin>
        where TUnpivotClauseAlias : ICommonUnpivotClauseAliasInJoin<TJoinEndType, TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableSelectionWithJoin>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
        where TCommonTableSelectionWithJoin : ISource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin, new()
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
