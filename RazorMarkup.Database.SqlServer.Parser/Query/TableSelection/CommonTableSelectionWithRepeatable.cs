using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithRepeatable<TEndType> : CommonTableSelectionWithTableHint<TEndType>,
        ICommonTableSelectionWithRepeatable
    {
        private readonly ITableSelectionWithRepeatable<TEndType> tableSelectionWithRepeatable;

        public CommonTableSelectionWithRepeatable(ITableSelectionWithRepeatable<TEndType> tableSelectionWithRepeatable)
            : base(tableSelectionWithRepeatable)
        {
            this.tableSelectionWithRepeatable = tableSelectionWithRepeatable;
        }

        public ICommonTableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            return new CommonTableSelectionWithTableHint<TEndType>(tableSelectionWithRepeatable.WithRepeatSeed(repeatSeed));
        }
    }
}
