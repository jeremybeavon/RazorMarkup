using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class DerivedTableWithAliasInJoin<TJoinEndType> :
        CommonDerivedTableWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>,
        IDerivedTableWithAliasInJoin<TJoinEndType>
    {
        public DerivedTableWithAliasInJoin(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder,
            TJoinEndType joinClosure)
            : base(
                  statement,
                  derivedTableBuilder,
                  builder => new TableSelectionWithJoinInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
