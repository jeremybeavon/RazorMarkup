using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal class TableSelectionWithAliasInJoin<TJoinEndType> : TableSelectionWithTableSampleInJoin<TJoinEndType>,
        ITableSelectionWithAliasInJoin<TJoinEndType>
    {
        public TableSelectionWithAliasInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithTableSampleInJoin<TJoinEndType> WithAlias(TableAlias tableAlias)
        {
            Statement.CurrentTable.TableAlias = tableAlias.ToSqlString();
            return this;
        }
    }
}
