using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class DerivedTableWithAlias<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>,
        IDerviedTableWithAlias<TEndType>
    {
        private readonly DerivedTableBuilder derivedTableBuilder;

        public DerivedTableWithAlias(FromClauseBuilder statement, DerivedTableBuilder derivedTableBuilder, TEndType endClosure)
            : base(statement, endClosure)
        {
            this.derivedTableBuilder = derivedTableBuilder;
        }

        public ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            derivedTableBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                derivedTableBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (IDerviedTableWithAlias<TEndType> input) => input.As(null, null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return new TableSelectionWithJoin<TEndType>(Statement, EndClosure);
        }
    }
}
