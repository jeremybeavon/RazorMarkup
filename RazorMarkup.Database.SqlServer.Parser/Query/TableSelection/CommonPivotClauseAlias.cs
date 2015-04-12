using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonPivotClauseAlias<TEndType> : ICommonPivotClauseAlias
    {
        private readonly IPivotClauseAlias<TEndType> pivotClauseAlias;

        public CommonPivotClauseAlias(IPivotClauseAlias<TEndType> pivotClauseAlias)
        {
            this.pivotClauseAlias = pivotClauseAlias;
        }

        public ICommonTableSelectionWithJoin As(TableAlias tableAlias)
        {
            return new CommonTableSelectionWithJoin<TEndType>(pivotClauseAlias.As(tableAlias));
        }
    }
}
