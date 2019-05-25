using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithTableHint<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableHint,
        TCommonTableSelectionWithTableHint> :
        CommonTableSelectionWithJoin<
            TJoinEndType,
            TTableSelectionInJoin, 
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonTableSelectionWithTableHint>,
        ICommonTableSelectionWithTableHint<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause, TTableHint>
        where TCommonTableSelectionWithTableHint : ICommonTableSelectionWithTableHint<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableHint>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableHint> tableHintBuilder;

        protected CommonTableSelectionWithTableHint(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableHint> tableHintBuilder)
            : base(
                  statement,
                  endClosure,
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
            return tableHintBuilder(Statement, JoinClosure);
        }
    }
}
