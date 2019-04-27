using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class SubqueryWithAlias : AbstractStatement<FromClauseBuilder>,
        ISubqueryWithAlias
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

            ISqlString columnAliasString = new SqlStringArray(typeof(ColumnAlias), columnAlias);
            Statement.Append((ISubqueryWithAlias input) => input.As(null), tableAlias, columnAliasString);
            return new TableSelectionWithJoin(Statement);
        }
    }
}
