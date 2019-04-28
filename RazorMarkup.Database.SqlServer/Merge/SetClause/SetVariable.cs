using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    internal sealed class SetVariable : CommonSetVariable<ISetClauseAnd, ISetValue>, ISetVariable
    {
        public SetVariable(SetClauseBuilder statement)
            : base(statement, SetClauseAnd.Create, SetValue.Create)
        {
        }
        
        public static ISetVariable Create(SetClauseBuilder statement)
        {
            return new SetVariable(statement);
        }
    }
}
