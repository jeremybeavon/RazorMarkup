using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonPivotClauseAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonPivotClauseAlias> :
        CommonTableSelectionWithJoin<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonPivotClauseAlias>,
        ICommonPivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
        where TCommonPivotClauseAlias : ICommonPivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder;

        public CommonPivotClauseAlias(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder)
        {
            this.tableSelectionWithJoinBuilder = tableSelectionWithJoinBuilder;
        }

        public TTableSelectionWithJoin As(TableAlias tableAlias)
        {
            Statement.CurrentPivot.TableAlias = tableAlias.ToSqlString();
            Statement.Append((TCommonPivotClauseAlias input) => input.As(null), tableAlias);
            return tableSelectionWithJoinBuilder(Statement);
        }
    }
}
