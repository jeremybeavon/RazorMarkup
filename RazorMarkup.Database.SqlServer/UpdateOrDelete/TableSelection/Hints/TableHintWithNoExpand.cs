using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints
{
    internal class TableHintWithNoExpand : TableHint, ITableHintWithNoExpand
    {
        public TableHintWithNoExpand(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public IAdditionalTableHint NoExpand()
        {
            Statement.CurrentTable.TableHintNoExpandIndexes.Add(Statement.CurrentTable.TableHints.Count);
            return new AdditionalTableHint(Statement);
        }
    }
}
