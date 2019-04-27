using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeUsing
    {
        ITableSource Using();
    }
}
