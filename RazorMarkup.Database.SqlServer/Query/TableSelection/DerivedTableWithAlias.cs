using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class DerivedTableWithAlias<TEndType> :
        CommonDerivedTableWithAlias<ITableSelectionWithJoin<TEndType>>,
        IDerivedTableWithAlias<TEndType>
    {
        public DerivedTableWithAlias(FromClauseBuilder statement, DerivedTableBuilder derivedTableBuilder, TEndType endClosure)
            : base(
                  statement,
                  derivedTableBuilder,
                  new TableSelectionFactory<TEndType>(endClosure).CreateTableSelectionWithJoin)
        {
        }
    }
}
