using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithRepeatable : ICommonTableSelectionWithTableHint
    {
        ICommonTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed);
    }
}
