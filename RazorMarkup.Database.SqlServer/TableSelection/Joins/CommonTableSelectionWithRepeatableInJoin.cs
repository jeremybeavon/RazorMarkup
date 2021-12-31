using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithRepeatableInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint,
        TCommonTableSelectionWithRepeatable> :
        CommonTableSelectionWithRepeatable<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSelectionWithTableHint,
            TCommonTableSelectionWithRepeatable>,
        ICommonTableSelectionWithRepeatableInJoin<
            TJoinEndType,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSelectionWithTableHint>
        where TCommonTableSelectionWithRepeatable : ICommonTableSelectionWithRepeatable<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSelectionWithTableHint>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithRepeatableInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableHint> tableHintBuilder,
            Func<FromClauseBuilder, TTableSelectionWithTableHint> tableSelectionWithTableHintBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  tableHintBuilder,
                  tableSelectionWithTableHintBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
