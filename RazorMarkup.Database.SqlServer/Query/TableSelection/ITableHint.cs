using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableHint<TEndType> : ICommonTableHint<ITableSelectionWithAdditionalTableHint<TEndType>>
    {
    }
}
