using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithAlias<TEndType> : CommonTableSelectionWithTableSample<TEndType>,
        ICommonTableSelectionWithAlias
    {
        private readonly ITableSelectionWithAlias<TEndType> tableSelectionWithAlias;

        public CommonTableSelectionWithAlias(ITableSelectionWithAlias<TEndType> tableSelectionWithAlias)
            : base(tableSelectionWithAlias)
        {
            this.tableSelectionWithAlias = tableSelectionWithAlias;
        }

        public ICommonTableSelectionWithTableSample WithAlias(TableAlias tableAlias)
        {
            return new CommonTableSelectionWithTableSample<TEndType>(tableSelectionWithAlias.WithAlias(tableAlias));
        }
    }
}
