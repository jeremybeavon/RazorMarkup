using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonPivotClauseIn<TEndType> : ICommonPivotClauseIn
    {
        private readonly IPivotClauseIn<TEndType> pivotClauseIn;

        public CommonPivotClauseIn(IPivotClauseIn<TEndType> pivotClauseIn)
        {
            this.pivotClauseIn = pivotClauseIn;
        }

        public ICommonPivotClauseAlias In(params ColumnName[] columns)
        {
            return new CommonPivotClauseAlias<TEndType>(pivotClauseIn.In(columns));
        }
    }
}
