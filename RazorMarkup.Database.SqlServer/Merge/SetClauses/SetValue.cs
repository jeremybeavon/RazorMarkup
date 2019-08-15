using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    internal sealed class SetValue : CommonSetValue<ISetClauseAnd>, ISetValue
    {
        public SetValue(SetClauseBuilder statement)
            : base(statement, SetClauseAnd.Create)
        {
        }

        public static ISetValue Create(SetClauseBuilder statement)
        {
            return new SetValue(statement);
        }
    }
}
