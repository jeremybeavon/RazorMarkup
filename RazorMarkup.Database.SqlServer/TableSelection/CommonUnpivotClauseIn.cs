using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonUnpivotClauseIn<TUnpivotClauseAlias> :
        AbstractStatement<FromClauseBuilder>,
        ICommonUnpivotClauseIn<TUnpivotClauseAlias>
    {
        private readonly Func<FromClauseBuilder, TUnpivotClauseAlias> unpivotClauseAliasBuilder;

        public CommonUnpivotClauseIn(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TUnpivotClauseAlias> unpivotClauseAliasBuilder)
            : base(statement)
        {
            this.unpivotClauseAliasBuilder = unpivotClauseAliasBuilder;
        }

        public TUnpivotClauseAlias In(params ColumnName[] columns)
        {
            Statement.CurrentUnpivot.ColumnList = columns.Select(column => column.ToSqlString()).ToArray();
            Statement.Append((ICommonUnpivotClauseIn<TUnpivotClauseAlias> input) => input.In(null), columns);
            return unpivotClauseAliasBuilder(Statement);
        }
    }
}
