using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    internal sealed class SetClause : CommonSetClause<ISetColumn, ISetVariable>, ISetClause
    {
        public SetClause(SetClauseBuilder statement)
            : base(statement, SetColumn.Create, SetVariable.Create)
        {
        }

        public static ISetClause Create(SetClauseBuilder statement)
        {
            return new SetClause(statement);
        }
    }
}
