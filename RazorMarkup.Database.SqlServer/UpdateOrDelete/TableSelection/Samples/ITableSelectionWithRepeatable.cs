using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSelectionWithRepeatable : ITableSelectionWithTableHint
    {
        ITableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }
}
