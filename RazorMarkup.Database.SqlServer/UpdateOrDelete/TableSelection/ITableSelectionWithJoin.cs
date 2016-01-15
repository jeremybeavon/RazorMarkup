using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithJoin : IEndFromClause
    {
        ITableSourceInJoin<ITableSelectionWithJoin> InnerJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullJoin();

        ITableSource CrossJoin();

        ITableSource CrossApplyJoin();

        ITableSource OuterApplyJoin();

        IPivotClause Pivot();
    } 
}
