﻿using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClauseAlias<TEndType> :
        ICommonUnpivotClauseAlias<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableSelectionWithJoin<TEndType>>,
        ITableSelectionWithJoin<TEndType>
    {
    }
}
