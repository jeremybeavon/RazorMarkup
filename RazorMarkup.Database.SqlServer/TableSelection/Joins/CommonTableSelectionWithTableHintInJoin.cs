using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithTableHintInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TCommonTableSelectionWithTableHint> :
        CommonTableSelectionWithTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TCommonTableSelectionWithTableHint>,
        ICommonTableSelectionWithTableHintInJoin<
            TJoinEndType,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>
        where TCommonTableSelectionWithTableHint : ICommonTableSelectionWithTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithTableHintInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableHint> tableHintBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  tableHintBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
