using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class Subquery<TParent> : AbstractQueryStatement<SelectClauseBuilder, IEndSubquery<TParent>>,
        ISubquery<TParent>
    {
        public Subquery(SelectClauseBuilder statement, TParent parent)
            : base(statement, new EndSubquery<TParent>(parent))
        {
        }

        public ISelectClauseWithDistinct<IEndSubquery<TParent>> Select()
        {
            Statement.Append((ISubquery<TParent> input) => input.Select());
            return new SelectClauseWithDistinct<IEndSubquery<TParent>>(Statement, EndClosure);
        }
    }
}
