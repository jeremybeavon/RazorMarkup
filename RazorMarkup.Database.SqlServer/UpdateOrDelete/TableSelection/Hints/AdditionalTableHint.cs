using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints
{
    internal class AdditionalTableHint : AbstractStatement<FromClauseBuilder>,
        IAdditionalTableHint
    {
        public AdditionalTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHint And()
        {
            return new TableHint(Statement);
        }
    }
}
