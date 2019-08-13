using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonPivotClauseIn<TPivotClauseAlias> :
        AbstractStatement<FromClauseBuilder>,
        ICommonPivotClauseIn<TPivotClauseAlias>
    {
        private readonly Func<FromClauseBuilder, TPivotClauseAlias> pivotClauseAliasBuilder;

        public CommonPivotClauseIn(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TPivotClauseAlias> pivotClauseAliasBuilder)
            : base(statement)
        {
            this.pivotClauseAliasBuilder = pivotClauseAliasBuilder;
        }

        public TPivotClauseAlias In(params ColumnName[] columns)
        {
            Statement.CurrentPivot.ColumnList = columns.Select(column => column.ToSqlString()).ToArray();
            Statement.Append((ICommonPivotClauseIn<TPivotClauseAlias> input) => input.In(null), columns);
            return pivotClauseAliasBuilder(Statement);
        }
    }
}
