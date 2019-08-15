using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    internal sealed class SetFieldOrProperty : CommonSetFieldOrProperty<ISetClauseAnd>, ISetFieldOrProperty
    {
        public SetFieldOrProperty(SetClauseBuilder statement)
            : base(statement, SetClauseAnd.Create)
        {
        }

        public static ISetFieldOrProperty Create(SetClauseBuilder statement)
        {
            return new SetFieldOrProperty(statement);
        }
    }
}
