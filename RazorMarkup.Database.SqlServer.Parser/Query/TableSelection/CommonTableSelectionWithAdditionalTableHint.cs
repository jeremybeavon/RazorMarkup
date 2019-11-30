using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithAdditionalTableHint<TEndType> : CommonTableSelectionWithJoin<TEndType>,
        ICommonTableSelectionWithAdditionalTableHint
    {
        private readonly ITableSelectionWithAdditionalTableHint<TEndType> tableSelectionWithAdditionalTableHint;

        public CommonTableSelectionWithAdditionalTableHint(ITableSelectionWithAdditionalTableHint<TEndType> tableSelectionWithAdditionalTableHint)
            : base(tableSelectionWithAdditionalTableHint)
        {
            this.tableSelectionWithAdditionalTableHint = tableSelectionWithAdditionalTableHint;
        }

        public new ICommonAdditionalTableHint And()
        {
            throw new global::System.NotImplementedException();
            //return new CommonTableHint<TEndType>(tableSelectionWithAdditionalTableHint.And());
        }
    }
}
