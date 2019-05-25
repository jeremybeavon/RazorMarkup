using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithAdditionalTableHint<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint,
        TCommonTableSelectionWithAdditionalTableHint> :
        CommonTableSelectionWithJoin<
            TJoinEndType,
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSelectionWithAdditionalTableHint>,
        ICommonTableSelectionWithAdditionalTableHint<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint>
        where TCommonTableSelectionWithAdditionalTableHint : ICommonTableSelectionWithAdditionalTableHint<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TAdditionalTableHint>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TAdditionalTableHint> additionalTableHintBuilder;

        protected CommonTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TAdditionalTableHint> additionalTableHintBuilder)
            : base(
                  statement,
                  endClosure,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder)
        {
            this.additionalTableHintBuilder = additionalTableHintBuilder;
        }

        public new TAdditionalTableHint And()
        {
            Statement.Append((TCommonTableSelectionWithAdditionalTableHint input) => input.And());
            return additionalTableHintBuilder(Statement, JoinClosure);
        }
    }
}
