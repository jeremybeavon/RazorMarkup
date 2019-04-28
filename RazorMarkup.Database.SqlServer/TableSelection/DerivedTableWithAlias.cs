using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal class DerivedTableWithAlias : AbstractStatement<FromClauseBuilder>,
        IDerviedTableWithAlias
    {
        private readonly DerivedTableBuilder derivedTableBuilder;

        public DerivedTableWithAlias(FromClauseBuilder statement, DerivedTableBuilder derivedTableBuilder)
            : base(statement)
        {
            this.derivedTableBuilder = derivedTableBuilder;
        }

        public ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            derivedTableBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                derivedTableBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (IDerviedTableWithAlias input) => input.As(null, null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return new TableSelectionWithJoin(Statement);
        }
    }
}
