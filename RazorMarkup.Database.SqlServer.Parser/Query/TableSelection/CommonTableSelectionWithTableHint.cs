using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithTableHint<TEndType> : CommonTableSelectionWithJoin<TEndType>,
        ICommonTableSelectionWithTableHint
    {
        private readonly ITableSelectionWithTableHint<TEndType> tableSelectionWithTableHint;

        public CommonTableSelectionWithTableHint(ITableSelectionWithTableHint<TEndType> tableSelectionWithTableHint)
            : base(tableSelectionWithTableHint)
        {
            this.tableSelectionWithTableHint = tableSelectionWithTableHint;
        }

        public ICommonTableHint WithHint()
        {
            return new CommonTableHint<TEndType>(tableSelectionWithTableHint.WithHint());
        }
    }
}
