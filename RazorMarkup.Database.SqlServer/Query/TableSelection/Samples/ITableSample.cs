using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSample<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithRepeatable<TEndType> Percent(Expression<Func<Float>> sampleNumber);

        ITableSelectionWithRepeatable<TEndType> Rows(Expression<Func<Integer>> sampleNumber);

        ITableSelectionWithRepeatable<TEndType> Sample(Expression<Func<Integer>> sampleNumber);
    }
}
