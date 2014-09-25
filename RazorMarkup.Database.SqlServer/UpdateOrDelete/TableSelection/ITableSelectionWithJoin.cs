using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithJoin : IEndFromClause
    {
        ITableSourceWithJoinHint<ITableSelectionWithJoin> InnerJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin> LeftJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin> RightJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin> FullJoin();

        ITableSource CrossJoin();

        ITableSource CrossApplyJoin();

        ITableSource OuterApplyJoin();

        IPivotClause Pivot();
    } 
}
