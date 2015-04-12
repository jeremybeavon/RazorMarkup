using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal abstract class AbstractJoinStatement<TEndType>
    {
        protected AbstractJoinStatement(Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
        {
            EndClosure = endClosure;
        }

        protected Func<TEndType, ICommonTableSelectionWithJoin> EndClosure { get; private set; }
    }
}
