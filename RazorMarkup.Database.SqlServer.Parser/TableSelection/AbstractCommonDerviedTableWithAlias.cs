using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonDerviedTableWithAlias<
        TDerivedTableWithAlias,
        TTableSelectionWithJoin,
        TCommonTableSelectionWithJoin> : AbstractSource<TDerivedTableWithAlias>, ICommonDerivedTableWithAlias
        where TDerivedTableWithAlias : ICommonDerivedTableWithAlias<TTableSelectionWithJoin>
        where TCommonTableSelectionWithJoin : ISource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin, new()
    {
        public ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            return new TCommonTableSelectionWithJoin()
            {
                Source = Source.As(tableAlias, columnAlias)
            };
        }
    }
}
