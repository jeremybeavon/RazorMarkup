using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithTableHintInJoin<TEndType> :
        CommonTableSelectionWithJoinInJoin<TEndType>,
        ICommonTableSelectionWithTableHint
    {
        private readonly ITableSelectionWithTableHintInJoin<TEndType> tableSelectionWithTableHint;

        public CommonTableSelectionWithTableHintInJoin(
            ITableSelectionWithTableHintInJoin<TEndType> tableSelectionWithTableHint,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSelectionWithTableHint, endClosure)
        {
            this.tableSelectionWithTableHint = tableSelectionWithTableHint;
        }

        public ICommonTableHint WithHint()
        {
            return new CommonTableHintInJoin<TEndType>(tableSelectionWithTableHint.WithHint(), EndClosure);
        }
    }
}
