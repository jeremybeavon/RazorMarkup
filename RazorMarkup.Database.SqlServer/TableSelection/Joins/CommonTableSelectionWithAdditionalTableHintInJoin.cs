using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithAdditionalTableHintInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint,
        TCommonTableSelectionWithAdditionalTableHint> :
        CommonTableSelectionWithAdditionalTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint,
            TCommonTableSelectionWithAdditionalTableHint>,
        ICommonTableSelectionWithAdditionalTableHintInJoin<
            TJoinEndType,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint>
        where TCommonTableSelectionWithAdditionalTableHint : ICommonTableSelectionWithAdditionalTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithAdditionalTableHintInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TAdditionalTableHint> additionalTableHintBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  additionalTableHintBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
