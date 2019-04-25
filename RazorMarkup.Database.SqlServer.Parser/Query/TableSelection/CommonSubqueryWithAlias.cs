using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonSubqueryWithAlias<TEndType> : ICommonSubqueryWithAlias
    {
        private readonly ISubqueryWithAlias<TEndType> subqueryWithAlias;

        public CommonSubqueryWithAlias(ISubqueryWithAlias<TEndType> subqueryWithAlias)
        {
            this.subqueryWithAlias = subqueryWithAlias;
        }

        public ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            return new CommonTableSelectionWithJoin<TEndType>(subqueryWithAlias.As(tableAlias, columnAlias));
        }
    }
}
