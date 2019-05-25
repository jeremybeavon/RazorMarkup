using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
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
