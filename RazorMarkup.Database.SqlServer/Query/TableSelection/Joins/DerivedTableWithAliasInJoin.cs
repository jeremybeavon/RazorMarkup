using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class DerivedTableWithAliasInJoin<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>,
        IDerviedTableWithAliasInJoin<TEndType>
    {
        private readonly DerivedTableBuilder derivedTableBuilder;

        public DerivedTableWithAliasInJoin(FromClauseBuilder statement, DerivedTableBuilder derivedTableBuilder, TEndType endClosure)
            : base(statement, endClosure)
        {
            this.derivedTableBuilder = derivedTableBuilder;
        }

        public ITableSelectionWithJoinInJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            derivedTableBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                derivedTableBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (IDerviedTableWithAliasInJoin<TEndType> input) => input.As(null, null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return new TableSelectionWithJoinInJoin<TEndType>(Statement, EndClosure);
        }
    }
}
