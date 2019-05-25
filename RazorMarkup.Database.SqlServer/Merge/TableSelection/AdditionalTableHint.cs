using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class AdditionalTableHint :
        AdditionalCommonTableHint<
            object,
            ITableSelectionWithAlias,
            ISubqueryWithAlias,
            IDerivedTableWithAlias,
            ITableSelectionWithAdditionalTableHint,
            IAdditionalTableHint>,
        IAdditionalTableHint
    {
        public AdditionalTableHint(FromClauseBuilder statement, object joinClosure)
            : base(
                  statement,
                  joinClosure,
                  TableSelectionWithAlias.Create,
                  SubqueryWithAlias.Create,
                  DerivedTableWithAlias.Create,
                  TableSelectionWithAdditionalTableHint.Create)
        {
        }

        public static IAdditionalTableHint Create(FromClauseBuilder statement, object joinClosure)
        {
            return new AdditionalTableHint(statement, joinClosure);
        }
    }
}
