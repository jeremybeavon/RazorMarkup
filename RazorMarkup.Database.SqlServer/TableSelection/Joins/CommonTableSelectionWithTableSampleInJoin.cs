using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithTableSampleInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TCommonTableSelectionWithTableSample> :
        CommonTableSelectionWithTableSample<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TCommonTableSelectionWithTableSample>,
        ICommonTableSelectionWithTableSampleInJoin<
            TJoinEndType,
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
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithTableSampleInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
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
                  tableHintBuilder,
                  tableSampleWithSystemBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
