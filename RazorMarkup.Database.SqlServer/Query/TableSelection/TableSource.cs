using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSource<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, ITableSource<TEndType>
    {
        public TableSource(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithAlias<TEndType> Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            return new TableSelectionWithAlias<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAlias<TEndType> View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            return new TableSelectionWithAlias<TEndType>(Statement, EndClosure);
        }

        public ISubquery<ISubqueryWithAlias<TEndType>> Subquery()
        {
            SubqueryBuilder builder = new SubqueryBuilder();
            Statement.Statements.Add(builder);
            ISubqueryWithAlias<TEndType> subquery = new SubqueryWithAlias<TEndType>(Statement, EndClosure);
            return new Subquery<ISubqueryWithAlias<TEndType>>(builder.Select, subquery);
        }
    }
}
