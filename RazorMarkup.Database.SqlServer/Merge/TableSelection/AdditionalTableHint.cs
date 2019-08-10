using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class AdditionalTableHint :
        AdditionalCommonTableHint<
            ITableSelectionWithAlias,
            ISubqueryWithAlias,
            IDerivedTableWithAlias,
            ITableSelectionWithAdditionalTableHint,
            IAdditionalTableHint>,
        IAdditionalTableHint
    {
        public AdditionalTableHint(FromClauseBuilder statement)
            : base(
                  statement,
                  TableSelectionWithAlias.Create,
                  SubqueryWithAlias.Create,
                  DerivedTableWithAlias.Create,
                  TableSelectionWithAdditionalTableHint.Create)
        {
        }

        public static IAdditionalTableHint Create(FromClauseBuilder statement)
        {
            return new AdditionalTableHint(statement);
        }
    }
}
