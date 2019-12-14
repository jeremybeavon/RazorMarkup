using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSource<TEndType> :
        AbstractCommonTableSource<
            ITableSource<TEndType>,
            ITableSelectionWithAlias<TEndType>,
            ISubqueryWithAlias<TEndType>,
            IDerivedTableWithAlias<TEndType>,
            CommonTableSelectionWithAlias<TEndType>,
            CommonSubqueryWithAlias<TEndType>,
            CommonDerivedTableWithAlias<TEndType>>
    {
    }
}
