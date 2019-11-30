using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSource :
        ICommonTableSource<
            ICommonTableSelectionWithAlias,
            ICommonSubqueryWithAlias,
            ICommonDerivedTableWithAlias>
    {
        ICommonSubqueryWithAlias Subquery(QueryExpression query);
    }
}
