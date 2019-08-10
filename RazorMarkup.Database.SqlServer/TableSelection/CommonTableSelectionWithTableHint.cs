using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithTableHint<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TCommonTableSelectionWithTableHint> :
        CommonTableSelectionWithJoin<
            TTableSourceInJoin, 
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSelectionWithTableHint>,
        ICommonTableSelectionWithTableHint<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint>
        where TCommonTableSelectionWithTableHint : ICommonTableSelectionWithTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>
    {
        private readonly Func<FromClauseBuilder, TTableHint> tableHintBuilder;

        protected CommonTableSelectionWithTableHint(
            FromClauseBuilder statement,
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
                  unpivotClauseBuilder)
        {
            this.tableHintBuilder = tableHintBuilder;
        }

        public TTableHint WithHint()
        {
            Statement.Append((TCommonTableSelectionWithTableHint input) => input.WithHint());
            return tableHintBuilder(Statement);
        }
    }
}
