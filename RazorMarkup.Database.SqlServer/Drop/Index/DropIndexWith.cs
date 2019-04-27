namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal class DropIndexWith : DropIndexAnd, IDropIndexWith
    {
        public DropIndexWith(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWithOptions With()
        {
            Statement.Append((IDropIndexWith input) => input.With());
            return new DropIndexWithOptions(Statement);
        }
    }
}
