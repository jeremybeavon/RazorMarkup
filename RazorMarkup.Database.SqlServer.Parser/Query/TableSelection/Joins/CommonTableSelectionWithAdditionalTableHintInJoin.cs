using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using System;


namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithAdditionalTableHintInJoin<TEndType> :
        CommonTableSelectionWithJoinInJoin<TEndType>,
        ICommonTableSelectionWithAdditionalTableHint
    {
        private readonly ITableSelectionWithAdditionalTableHintInJoin<TEndType> tableSelectionWithAdditionalTableHint;

        public CommonTableSelectionWithAdditionalTableHintInJoin(
            ITableSelectionWithAdditionalTableHintInJoin<TEndType> tableSelectionWithAdditionalTableHint,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSelectionWithAdditionalTableHint, endClosure)
        {
            this.tableSelectionWithAdditionalTableHint = tableSelectionWithAdditionalTableHint;
        }

        public new ICommonTableHint And()
        {
            return new CommonTableHintInJoin<TEndType>(tableSelectionWithAdditionalTableHint.And(), EndClosure);
        }
    }
}
