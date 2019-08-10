using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IAdditionalTableHint<TEndType> : 
        IAdditionalCommonTableHint<
            ITableSelectionWithAlias<TEndType>,
            ISubqueryWithAlias<TEndType>,
            IDerivedTableWithAlias<TEndType>,
            ITableSelectionWithAdditionalTableHint<TEndType>>
    {
    }
}
