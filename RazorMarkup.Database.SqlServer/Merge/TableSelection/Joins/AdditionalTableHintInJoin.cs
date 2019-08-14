using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class AdditionalTableHintInJoin<TJoinEndType> :
        AdditionalCommonTableHint<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>,
            IAdditionalTableHintInJoin<TJoinEndType>>,
        IAdditionalTableHintInJoin<TJoinEndType>
    {
        public AdditionalTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private AdditionalTableHintInJoin(FromClauseBuilder statement, TableSelectionInJoinFactory<TJoinEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSelectionWithAlias,
                  factory.CreateSubqueryWithAlias,
                  factory.CreateDerivedTableWithAlias,
                  factory.CreateTableSelectionWithAdditionalTableHint)
        {
        }
    }
}
