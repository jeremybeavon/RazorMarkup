using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    public interface IFromClause : IHideObjectMethods
    {
        ITableSource From();
    }
}
