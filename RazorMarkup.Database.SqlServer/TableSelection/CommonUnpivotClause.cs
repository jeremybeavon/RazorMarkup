using RazorMarkup.Database.SqlServer.Query.Builders;
using System;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonUnpivotClause<TUnpivotClauseIn> :
        AbstractStatement<FromClauseBuilder>,
        ICommonUnpivotClause<TUnpivotClauseIn>
    {
        private readonly Func<FromClauseBuilder, TUnpivotClauseIn> unpivotClauseInBuilder;

        public CommonUnpivotClause(FromClauseBuilder statement, Func<FromClauseBuilder, TUnpivotClauseIn> unpivotClauseInBuilder)
            : base(statement)
        {
            this.unpivotClauseInBuilder = unpivotClauseInBuilder;
        }

        public TUnpivotClauseIn For(ColumnName columnName)
        {
            Statement.CurrentUnpivot.PivotColumn = columnName.ToSqlString();
            Statement.Append((ICommonUnpivotClause<TUnpivotClauseIn> input) => input.For(null), columnName);
            return unpivotClauseInBuilder(Statement);
        }
    }
}
