using RazorMarkup.Database.SqlServer.SetClause;
using System;
using System.Linq.Expressions;

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
