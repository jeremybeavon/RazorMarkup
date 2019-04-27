namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexWithAnd : DropIndexAnd, IDropIndexWithAnd
    {
        public DropIndexWithAnd(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWithOptions And()
        {
            Statement.Append((IDropIndexWithAnd input) => input.And());
            return new DropIndexWithOptions(Statement);
        }
    }
}
