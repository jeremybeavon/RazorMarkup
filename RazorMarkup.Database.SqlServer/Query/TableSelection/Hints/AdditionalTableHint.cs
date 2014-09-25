using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Hints
{
    internal class AdditionalTableHint<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>,
        IAdditionalTableHint<TEndType>
    {
        public AdditionalTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableHint<TEndType> And()
        {
            return new TableHint<TEndType>(Statement, EndClosure);
        }
    }
}
