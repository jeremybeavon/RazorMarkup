using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonUnpivotClause<TEndType> : ICommonUnpivotClause
    {
        private readonly IUnpivotClause<TEndType> unpivotClause;

        public CommonUnpivotClause(IUnpivotClause<TEndType> unpivotClause)
        {
            this.unpivotClause = unpivotClause;
        }

        public ICommonUnpivotClauseIn For(ColumnName columnName)
        {
            return new CommonUnpivotClauseIn<TEndType>(unpivotClause.For(columnName));
        }
    }
}
