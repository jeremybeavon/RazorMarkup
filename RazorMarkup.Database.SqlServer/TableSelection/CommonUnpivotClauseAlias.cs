using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonUnpivotClauseAlias<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonUnpivotClauseAlias> :
        CommonTableSelectionWithJoin<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TCommonUnpivotClauseAlias>,
        ICommonUnpivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
        where TCommonUnpivotClauseAlias : ICommonUnpivotClauseAlias<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder;

        public CommonUnpivotClauseAlias(
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
            Statement.CurrentUnpivot.TableAlias = tableAlias.ToSqlString();
            Statement.Append((TCommonUnpivotClauseAlias input) => input.As(null), tableAlias);
            return tableSelectionWithJoinBuilder(Statement);
        }
    }
}
