using RazorMarkup.Database.SqlServer.SetClause;
using System;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
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
