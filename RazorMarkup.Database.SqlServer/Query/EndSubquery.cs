namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class EndSubquery<TParent> : IEndSubquery<TParent>
    {
        private readonly TParent parent;

        public EndSubquery(TParent parent)
        {
            this.parent = parent;
        }

        public TParent Subquery()
        {
            return parent;
        }
    }
}
