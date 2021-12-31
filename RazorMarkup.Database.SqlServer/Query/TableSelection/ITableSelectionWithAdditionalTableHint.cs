﻿using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint<TEndType> :
        ICommonTableSelectionWithAdditionalTableHint<
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            IAdditionalTableHint<TEndType>>,
        ITableSelectionWithJoin<TEndType>
    {
    }
}
