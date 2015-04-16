using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonDerviedTableWithAlias<TEndType> : ICommonDerivedTableWithAlias
    {
        private readonly IDerviedTableWithAlias<TEndType> derivedTableWithAlias;

        public CommonDerviedTableWithAlias(IDerviedTableWithAlias<TEndType> derivedTableWithAlias)
        {
            this.derivedTableWithAlias = derivedTableWithAlias;
        }

        public ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            return new CommonTableSelectionWithJoin<TEndType>(derivedTableWithAlias.As(tableAlias, columnAlias));
        }
    }
}
