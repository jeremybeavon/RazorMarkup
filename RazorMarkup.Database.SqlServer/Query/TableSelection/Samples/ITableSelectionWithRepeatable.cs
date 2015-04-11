using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSelectionWithRepeatable<TEndType> : ITableSelectionWithTableHint<TEndType>
    {
        ITableSelectionWithTableHint<TEndType> WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }
}
