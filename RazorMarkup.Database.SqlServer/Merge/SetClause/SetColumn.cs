using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    internal sealed class SetColumn : CommonSetColumn<ISetClauseAnd, ISetFieldOrProperty>, ISetColumn
    {
        public SetColumn(SetClauseBuilder statement)
            : base(statement, SetClauseAnd.Create, SetFieldOrProperty.Create)
        {
        }

        public static ISetColumn Create(SetClauseBuilder statement)
        {
            return new SetColumn(statement);
        }
    }
}
