﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSource : ICommonTableSource<ITableSelectionWithAlias, ISubqueryWithAlias, IDerivedTableWithAlias>
    {
    }
}
