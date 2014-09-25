using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSourceInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
