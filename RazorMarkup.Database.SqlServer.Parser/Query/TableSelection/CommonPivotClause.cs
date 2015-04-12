using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonPivotClause<TEndType> : ICommonPivotClause
    {
        private readonly IPivotClause<TEndType> pivotClause;

        public CommonPivotClause(IPivotClause<TEndType> pivotClause)
        {
            this.pivotClause = pivotClause;
        }

        public ICommonPivotClauseIn For(ColumnName columnName)
        {
            return new CommonPivotClauseIn<TEndType>(pivotClause.For(columnName));
        }
    }
}
