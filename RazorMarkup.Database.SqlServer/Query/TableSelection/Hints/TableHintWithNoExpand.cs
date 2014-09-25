using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Hints
{
    internal class TableHintWithNoExpand<TEndType> : TableHint<TEndType>, ITableHintWithNoExpand<TEndType>
    {
        public TableHintWithNoExpand(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IAdditionalTableHint<TEndType> NoExpand()
        {
            Statement.CurrentTable.TableHintNoExpandIndexes.Add(Statement.CurrentTable.TableHints.Count);
            return new AdditionalTableHint<TEndType>(Statement, EndClosure);
        }
    }
}
