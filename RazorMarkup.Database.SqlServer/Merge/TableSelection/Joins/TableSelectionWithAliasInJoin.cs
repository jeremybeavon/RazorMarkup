using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
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
            Statement.Append((ITableSelectionWithAliasInJoin<TJoinEndType> input) => input.WithAlias(null), tableAlias);
            return this;
        }
    }
}
