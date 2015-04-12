using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonJoinHint<TEndType> : AbstractJoinStatement<TEndType>, ICommonJoinHint
    {
        private readonly IJoinHint<TEndType> joinHint;

        public CommonJoinHint(IJoinHint<TEndType> joinHint, Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.joinHint = joinHint;
        }

        public ICommonTableSource Loop()
        {
            return new CommonTableSourceInJoin<TEndType>(joinHint.Loop(), EndClosure);
        }

        public ICommonTableSource Hash()
        {
            return new CommonTableSourceInJoin<TEndType>(joinHint.Hash(), EndClosure);
        }

        public ICommonTableSource Merge()
        {
            return new CommonTableSourceInJoin<TEndType>(joinHint.Merge(), EndClosure);
        }

        public ICommonTableSource Remote()
        {
            return new CommonTableSourceInJoin<TEndType>(joinHint.Remote(), EndClosure);
        }
    }
}
