using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection.Samples
{
    public interface ITableSample : IHideObjectMethods
    {
        ITableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber);

        ITableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber);

        ITableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber);
    }
}
