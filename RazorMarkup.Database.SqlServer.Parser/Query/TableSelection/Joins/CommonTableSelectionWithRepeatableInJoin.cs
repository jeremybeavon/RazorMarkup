using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Samples;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithRepeatableInJoin<TEndType> :
        CommonTableSelectionWithTableHintInJoin<TEndType>,
        ICommonTableSelectionWithRepeatable
    {
        private readonly ITableSelectionWithRepeatableInJoin<TEndType> tableSelectionWithRepeatable;

        public CommonTableSelectionWithRepeatableInJoin(
            ITableSelectionWithRepeatableInJoin<TEndType> tableSelectionWithRepeatable,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSelectionWithRepeatable, endClosure)
        {
            this.tableSelectionWithRepeatable = tableSelectionWithRepeatable;
        }

        public ICommonTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            return new CommonTableSelectionWithTableHintInJoin<TEndType>(
                tableSelectionWithRepeatable.WithRepeatSeed(repeatSeed),
                EndClosure);
        }
    }
}
