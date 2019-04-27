namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexStatement : AbstractStatement<DropIndexStatementBuilder>, IDropIndexStatement
    {
        public DropIndexStatement(IndexName indexName)
            : base(new DropIndexStatementBuilder(indexName))
        {
            Statement.Initialize(() => Sql.Drop().Index(null), indexName);
        }

        public DropIndexStatement(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWith On(TableName tableName)
        {
            Statement.CurrentIndex.TableOrViewName = tableName.ToSqlString();
            Statement.Append((IDropIndexStatement input) => input.On((TableName)null), tableName);
            return new DropIndexWith(Statement);
        }

        public IDropIndexWith On(ViewName viewName)
        {
            Statement.CurrentIndex.TableOrViewName = viewName.ToSqlString();
            Statement.Append((IDropIndexStatement input) => input.On((ViewName)null), viewName);
            return new DropIndexWith(Statement);
        }
    }
}
