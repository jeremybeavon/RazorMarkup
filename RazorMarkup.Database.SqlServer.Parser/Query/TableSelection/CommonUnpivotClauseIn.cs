using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonUnpivotClauseIn<TEndType> : ICommonUnpivotClauseIn
    {
        private readonly IUnpivotClauseIn<TEndType> unpivotClauseIn;

        public CommonUnpivotClauseIn(IUnpivotClauseIn<TEndType> unpivotClauseIn)
        {
            this.unpivotClauseIn = unpivotClauseIn;
        }

        public ICommonUnpivotClauseAlias In(params ColumnName[] columnNames)
        {
            return new CommonUnpivotClauseAlias<TEndType>(unpivotClauseIn.In(columnNames));
        }
    }
}
