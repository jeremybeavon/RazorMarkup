using System;
using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonDerivedTableWithAlias<TTableSelectionWithJoin> :
        AbstractStatement<FromClauseBuilder>,
        ICommonDerivedTableWithAlias<TTableSelectionWithJoin>
    {
        private readonly DerivedTableBuilder derivedTableBuilder;
        private readonly Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder;

        protected CommonDerivedTableWithAlias(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder,
            Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder)
            : base(statement)
        {
            this.derivedTableBuilder = derivedTableBuilder;
            this.tableSelectionWithJoinBuilder = tableSelectionWithJoinBuilder;
        }

        public TTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            derivedTableBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                derivedTableBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (ICommonDerivedTableWithAlias<TTableSelectionWithJoin> input) => input.As(null, null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return tableSelectionWithJoinBuilder(Statement);
        }
    }
}
