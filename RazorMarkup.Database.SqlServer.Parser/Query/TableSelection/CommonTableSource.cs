using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSource<TEndType> : ICommonTableSource
    {
        private readonly ITableSource<TEndType> tableSource;

        public CommonTableSource(ITableSource<TEndType> tableSource)
        {
            this.tableSource = tableSource;
        }

        public ICommonTableSelectionWithAlias Table(TableName tableName)
        {
            return new CommonTableSelectionWithAlias<TEndType>(tableSource.Table(tableName));
        }

        public ICommonTableSelectionWithAlias View(ViewName viewName)
        {
            return new CommonTableSelectionWithAlias<TEndType>(tableSource.View(viewName));
        }
    }
}
