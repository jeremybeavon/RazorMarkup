using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal class TableSourceInJoin : TableSourceInJoin<ITableSelectionWithJoin>, ITableSourceInJoinWithTableSelection
    {
        public TableSourceInJoin(FromClauseBuilder statement, ITableSelectionWithJoin joinClosure)
            : base(statement, joinClosure)
        {
        }
    }

    internal class TableSourceInJoin2<TJoinEndType> : TableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>
    {
        public TableSourceInJoin2(FromClauseBuilder statement, ITableSelectionWithJoinInJoin<TJoinEndType> joinClosure)
            : base(statement, joinClosure)
        {
        }
    }

    internal class TableSourceInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> Table(TableName tableName)
        {
            TableQueryBuilder builder = new(ExpressionBuilder)
            {
                TableName = tableName.ToSqlString()
            };
            Statement.Statements.Add(builder);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> View(ViewName viewName)
        {
            TableQueryBuilder builder = new(ExpressionBuilder)
            {
                TableName = viewName.ToSqlString()
            };
            Statement.Statements.Add(builder);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
