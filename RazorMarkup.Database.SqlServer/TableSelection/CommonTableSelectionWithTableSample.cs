using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithTableSample<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TCommonTableSelectionWithTableSample> :
        CommonTableSelectionWithTableHint<
            TJoinEndType,
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TCommonTableSelectionWithTableSample>,
        ICommonTableSelectionWithTableSample<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>
        where TCommonTableSelectionWithTableSample : ICommonTableSelectionWithTableSample<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSampleWithSystem> tableSampleWithSystemBuilder;

        protected CommonTableSelectionWithTableSample(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableHint> tableHintBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSampleWithSystem> tableSampleWithSystemBuilder)
            : base(
                  statement,
                  endClosure,
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
            return tableSampleWithSystemBuilder(Statement, JoinClosure);
        }
    }
}
