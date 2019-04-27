namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal class DropIndexAnd : AbstractStatement<DropIndexStatementBuilder>, IDropIndexAnd
    {
        public DropIndexAnd(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexStatement And(IndexName indexName)
        {
            Statement.Indexes.Add(new DropSingleIndexStatementBuilder(indexName));
            Statement.Append((IDropIndexAnd input) => input.And(null), indexName);
            return new DropIndexStatement(Statement);
        }
    }
}
