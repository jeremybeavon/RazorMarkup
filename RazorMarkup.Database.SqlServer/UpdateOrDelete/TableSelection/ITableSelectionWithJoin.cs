using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSourceInJoinWithTableSelection : ITableSourceInJoin<ITableSelectionWithJoin>
    {
    }

    public interface ITableSelectionWithJoin : IEndFromClause
    {
        ITableSourceInJoinWithTableSelection InnerJoin();

        ITableSourceInJoinWithTableSelection LeftJoin();

        ITableSourceInJoinWithTableSelection RightJoin();

        ITableSourceInJoinWithTableSelection FullJoin();

        ITableSource CrossJoin();

        ITableSource CrossApplyJoin();

        ITableSource OuterApplyJoin();

        IPivotClause Pivot();
    }
}
