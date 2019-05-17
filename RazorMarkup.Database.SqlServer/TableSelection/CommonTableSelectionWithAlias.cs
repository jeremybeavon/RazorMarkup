using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample,
        TCommonTableSelectionWithAlias> :
        CommonTableSelectionWithTableSample<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TCommonTableSelectionWithAlias>,
        ICommonTableSelectionWithAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample>
        where TCommonTableSelectionWithAlias : ICommonTableSelectionWithAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithTableSample> tableSelectionWithTableSampleBuilder;

        protected CommonTableSelectionWithAlias(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableHint> tableHintBuilder,
            Func<FromClauseBuilder, TTableSampleWithSystem> tableSampleWithSystemBuilder,
            Func<FromClauseBuilder, TTableSelectionWithTableSample> tableSelectionWithTableSampleBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  tableHintBuilder,
                  tableSampleWithSystemBuilder)
        {
            this.tableSelectionWithTableSampleBuilder = tableSelectionWithTableSampleBuilder;
        }

        public TTableSelectionWithTableSample As(TableAlias tableAlias)
        {
            Statement.CurrentTable.TableAlias = tableAlias.ToSqlString();
            Statement.Append((TCommonTableSelectionWithAlias input) => input.As(null), tableAlias);
            return tableSelectionWithTableSampleBuilder(Statement);
        }
    }
}
