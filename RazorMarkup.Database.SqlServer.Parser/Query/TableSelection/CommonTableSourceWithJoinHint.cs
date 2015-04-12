using System;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSourceWithJoinHint<TEndType> : CommonTableSourceInJoin<TEndType>,
        ICommonTableSourceWithJoinHint
    {
        private readonly ITableSourceWithJoinHint<TEndType> tableSourceWithJoinHint;

        public CommonTableSourceWithJoinHint(
            ITableSourceWithJoinHint<TEndType> tableSourceWithJoinHint,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSourceWithJoinHint, endClosure)
        {
            this.tableSourceWithJoinHint = tableSourceWithJoinHint;
        }

        public ICommonJoinHint WithHint()
        {
            return new CommonJoinHint<TEndType>(tableSourceWithJoinHint.WithHint(), EndClosure);
        }
    }
}
