using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;
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
            //: base(tableSelectionWithAdditionalTableHint, endClosure)
            : base(null, endClosure)
        {
            this.tableSelectionWithAdditionalTableHint = tableSelectionWithAdditionalTableHint;
        }

        public new ICommonTableHint And()
        {
            throw new NotImplementedException();
            //return new CommonTableHintInJoin<TEndType>(tableSelectionWithAdditionalTableHint.And(), EndClosure);
        }

        ICommonAdditionalTableHint ICommonTableSelectionWithAdditionalTableHint<ICommonTableSource, ICommonTableSource, ICommonPivotClause, ICommonUnpivotClause, ICommonAdditionalTableHint>.And()
        {
            throw new NotImplementedException();
        }
    }
}
