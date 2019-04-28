using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins.Samples
{
    public interface ITableSampleInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithRepeatableInJoin<TJoinEndType> Percent(Expression<Func<Float>> sampleNumber);

        ITableSelectionWithRepeatableInJoin<TJoinEndType> Rows(Expression<Func<Integer>> sampleNumber);

        ITableSelectionWithRepeatableInJoin<TJoinEndType> Sample(Expression<Func<Integer>> sampleNumber);
    }
}
