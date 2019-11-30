using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonUnpivotClauseAlias<TEndType> : CommonTableSelectionWithJoin<TEndType>, ICommonUnpivotClauseAlias
    {
        private readonly IUnpivotClauseAlias<TEndType> unpivotClauseAlias;

        public CommonUnpivotClauseAlias(IUnpivotClauseAlias<TEndType> unpivotClauseAlias)
            : base(unpivotClauseAlias)
        {
            this.unpivotClauseAlias = unpivotClauseAlias;
        }

        public ICommonTableSelectionWithJoin As(TableAlias tableAlias)
        {
            return new CommonTableSelectionWithJoin<TEndType>(unpivotClauseAlias.As(tableAlias));
        }
    }
}
