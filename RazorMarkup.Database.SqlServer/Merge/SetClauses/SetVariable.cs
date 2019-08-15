using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
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
