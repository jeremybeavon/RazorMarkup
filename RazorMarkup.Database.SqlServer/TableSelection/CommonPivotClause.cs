using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonPivotClause<TPivotClauseIn> :
        AbstractStatement<FromClauseBuilder>,
        ICommonPivotClause<TPivotClauseIn>
    {
        private readonly Func<FromClauseBuilder, TPivotClauseIn> pivotClauseInBuilder;

        public CommonPivotClause(FromClauseBuilder statement, Func<FromClauseBuilder, TPivotClauseIn> pivotClauseInBuilder)
            : base(statement)
        {
            this.pivotClauseInBuilder = pivotClauseInBuilder;
        }

        public TPivotClauseIn For(ColumnName columnName)
        {
            Statement.CurrentPivot.PivotColumn = columnName.ToSqlString();
            Statement.Append((ICommonPivotClause<TPivotClauseIn> input) => input.For(null), columnName);
            return pivotClauseInBuilder(Statement);
        }
    }
}
