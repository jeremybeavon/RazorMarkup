using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithAdditionalTableHint<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TAdditionalTableHint,
        TCommonTableSelectionWithAdditionalTableHint> :
        CommonTableSelectionWithJoin<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSelectionWithAdditionalTableHint>,
        ICommonTableSelectionWithAdditionalTableHint<
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
        private readonly Func<FromClauseBuilder, TAdditionalTableHint> additionalTableHintBuilder;

        protected CommonTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement,
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
                  unpivotClauseBuilder)
        {
            this.additionalTableHintBuilder = additionalTableHintBuilder;
        }

        public new TAdditionalTableHint And()
        {
            Statement.Append((TCommonTableSelectionWithAdditionalTableHint input) => input.And());
            return additionalTableHintBuilder(Statement);
        }
    }
}
