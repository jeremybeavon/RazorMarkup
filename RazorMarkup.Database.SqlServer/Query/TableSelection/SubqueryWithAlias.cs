using System;
using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class SubqueryWithAlias<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>,
        ISubqueryWithAlias<TEndType>
    {
        public SubqueryWithAlias(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            SubqueryBuilder subqueryBuilder = Statement.CurrentSubquery;
            subqueryBuilder.TableAlias = tableAlias.ToSqlString();
            foreach (ColumnAlias alias in columnAlias)
            {
                subqueryBuilder.ColumnAlias.Add(alias.ToSqlString());
            }

            ISqlString columnAliasString = new SqlStringArray(typeof(ColumnAlias), columnAlias);
            Statement.Append((ISubqueryWithAlias<TEndType> input) => input.As(null), tableAlias, columnAliasString);
            return new TableSelectionWithJoin<TEndType>(Statement, EndClosure);
        }
    }
}
