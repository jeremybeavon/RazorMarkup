using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonTableSelectionWithAliasInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TTableSampleWithSystem,
        TTableSelectionWithTableSample,
        TCommonTableSelectionWithTableSourceInJoin,
        TCommonTableSelectionWithAlias> :
        CommonTableSelectionWithAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint,
            TTableSampleWithSystem,
            TTableSelectionWithTableSample,
            TCommonTableSelectionWithAlias>,
        ICommonTableSelectionWithAliasInJoin<
            TJoinEndType,
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
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonTableSelectionWithAliasInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
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
                  tableSampleWithSystemBuilder,
                  tableSelectionWithTableSampleBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
