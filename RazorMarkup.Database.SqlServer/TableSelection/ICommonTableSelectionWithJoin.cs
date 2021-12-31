using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause> :
        IHideObjectMethods
    {
        TTableSource CrossJoin();

        TTableSource CrossApplyJoin();

        TTableSource OuterApplyJoin();

        TPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        TUnpivotClause Unpivot(ColumnName columnName);

        TTableSource And();
    }

    public interface ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause> :
        ICommonTableSelectionWithJoin<TTableSource, TPivotClause, TUnpivotClause>
    {
    }
}
