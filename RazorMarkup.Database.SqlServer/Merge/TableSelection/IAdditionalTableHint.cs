using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IAdditionalTableHint :
        IAdditionalCommonTableHint<
            ITableSelectionWithAlias,
            ISubqueryWithAlias,
            IDerivedTableWithAlias,
            ITableSelectionWithAdditionalTableHint>
    {
    }
}
