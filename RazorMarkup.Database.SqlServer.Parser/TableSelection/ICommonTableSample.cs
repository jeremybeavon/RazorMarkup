using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSample
    {
        ICommonTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber);

        ICommonTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber);

        ICommonTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber);
    }
}
