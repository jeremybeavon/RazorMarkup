using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class SubqueryWithAlias : AbstractStatement<FromClauseBuilder>, ISubqueryWithAlias
    {
        public SubqueryWithAlias(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            SubqueryBuilder subqueryBuilder = Statement.CurrentSubquery;
            subqueryBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                subqueryBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            Statement.Append(
                (ISubqueryWithAlias input) => input.As(null),
                (new ISqlString[] { tableAlias }).Concat(columnAlias).ToArray());
            return new TableSelectionWithJoin(Statement);
        }
    }
}
