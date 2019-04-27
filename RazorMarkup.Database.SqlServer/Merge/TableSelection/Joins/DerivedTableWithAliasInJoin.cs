using System.Linq;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class DerivedTableWithAliasInJoin<TJoinEndType> : AbstractQueryStatement<FromClauseBuilder, TJoinEndType>,
        IDerviedTableWithAliasInJoin<TJoinEndType>
    {
        private readonly DerivedTableBuilder derivedTableBuilder;

        public DerivedTableWithAliasInJoin(FromClauseBuilder statement, DerivedTableBuilder derivedTableBuilder, TJoinEndType endClosure)
            : base(statement, endClosure)
        {
            this.derivedTableBuilder = derivedTableBuilder;
        }

        public ITableSelectionWithJoinInJoin<TJoinEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            derivedTableBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                derivedTableBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (IDerviedTableWithAliasInJoin<TJoinEndType> input) => input.As(null, null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return new TableSelectionWithJoinInJoin<TJoinEndType>(Statement, EndClosure);
        }
    }
}
