using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithTableSample<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TCommonTableSelectionWithTableSample> :
        CommonTableSelectionWithTableHint<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TCommonTableSelectionWithTableSample>,
        ICommonTableSelectionWithTableSample<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>
        where TCommonTableSelectionWithTableSample : ICommonTableSelectionWithTableSample<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>
    {
        private readonly Func<FromClauseBuilder, TTableSampleWithSystem> tableSampleWithSystemBuilder;

        protected CommonTableSelectionWithTableSample(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableHint> tableHintBuilder,
            Func<FromClauseBuilder, TTableSampleWithSystem> tableSampleWithSystemBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  tableHintBuilder)
        {
            this.tableSampleWithSystemBuilder = tableSampleWithSystemBuilder;
        }

        public TTableSampleWithSystem TableSample()
        {
            Statement.Append((TCommonTableSelectionWithTableSample input) => input.TableSample());
            return tableSampleWithSystemBuilder(Statement);
        }
    }
}
