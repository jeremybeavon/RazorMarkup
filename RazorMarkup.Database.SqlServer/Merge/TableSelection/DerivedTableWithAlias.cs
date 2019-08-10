using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class DerivedTableWithAlias : CommonDerivedTableWithAlias<ITableSelectionWithJoin>,
        IDerivedTableWithAlias
    {
        public DerivedTableWithAlias(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder)
            : base(statement, derivedTableBuilder, TableSelectionWithJoin.Create)
        {
        }

        public static IDerivedTableWithAlias Create(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAlias(statement, derivedTableBuilder);
        }
    }
}
