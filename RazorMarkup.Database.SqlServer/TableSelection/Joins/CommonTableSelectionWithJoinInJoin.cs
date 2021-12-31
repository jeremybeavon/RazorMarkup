using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithJoinInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TCommonTableSelectionWithJoin> :
        CommonTableSelectionWithJoin<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSelectionWithJoin>,
        ICommonTableSelectionWithJoinInJoin<
            TJoinEndType,
            TTableSource,
            TPivotClause,
            TUnpivotClause>
        where TCommonTableSelectionWithJoin : ICommonTableSelectionWithJoin<
            TTableSource,
            TPivotClause,
            TUnpivotClause>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithJoinInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder)
            : base(statement, tableSourceInJoinBuilder, tableSourceBuilder, pivotClauseBuilder, unpivotClauseBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
