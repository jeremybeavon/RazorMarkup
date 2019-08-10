using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IDerivedTableWithAlias<TEndType> :
        ICommonDerivedTableWithAlias<ITableSelectionWithJoin<TEndType>>
    {
    }
}
