using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples
{
    public interface ITableSelectionWithRepeatableInJoin<TJoinEndType> :
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        ITableSelectionWithTableHintInJoin<TJoinEndType> WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }
}
