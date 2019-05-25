using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class DerivedTableWithAlias : CommonDerivedTableWithAlias<object, ITableSelectionWithJoin>,
        IDerivedTableWithAlias
    {
        public DerivedTableWithAlias(
            FromClauseBuilder statement,
            object joinClosure,
            DerivedTableBuilder derivedTableBuilder)
            : base(statement, joinClosure, derivedTableBuilder, TableSelectionWithJoin.Create)
        {
        }

        public static IDerivedTableWithAlias Create(
            FromClauseBuilder statement,
            object joinClosure,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAlias(statement, joinClosure, derivedTableBuilder);
        }
    }
}
