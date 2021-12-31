using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithRepeatable<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSelectionWithTableHint,
        TCommonTableSelectionWithRepeatable> :
        CommonTableSelectionWithTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TCommonTableSelectionWithRepeatable>,
        ICommonTableSelectionWithRepeatable<
            TTableSourceInJoin,
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
        private readonly Func<FromClauseBuilder, TTableSelectionWithTableHint> tableSelectionWithTableHintBuilder;

        protected CommonTableSelectionWithRepeatable(
            FromClauseBuilder statement,
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
                  tableHintBuilder)
        {
            this.tableSelectionWithTableHintBuilder = tableSelectionWithTableHintBuilder;
        }

        public TTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<Integer>(repeatSeed);
            Statement.Append((TCommonTableSelectionWithRepeatable input) => input.WithRepeatSeed(null), repeatSeed);
            return tableSelectionWithTableHintBuilder(Statement);
        }
    }
}
