using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithAlias<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample,
        TCommonTableSelectionWithAlias> :
        CommonTableSelectionWithTableSample<
            TJoinEndType,
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TCommonTableSelectionWithAlias>,
        ICommonTableSelectionWithAlias<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample>
        where TCommonTableSelectionWithAlias : ICommonTableSelectionWithAlias<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithTableSample> tableSelectionWithTableSampleBuilder;

        protected CommonTableSelectionWithAlias(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableHint> tableHintBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSampleWithSystem> tableSampleWithSystemBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithTableSample> tableSelectionWithTableSampleBuilder)
            : base(
                  statement,
                  endClosure,
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
            return tableSelectionWithTableSampleBuilder(Statement, JoinClosure);
        }
    }
}
