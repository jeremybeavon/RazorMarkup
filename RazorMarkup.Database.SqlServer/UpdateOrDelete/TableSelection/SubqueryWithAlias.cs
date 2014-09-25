using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class SubqueryWithAlias : AbstractStatement<FromClauseBuilder>,
        ISubqueryWithAlias
    {
        public SubqueryWithAlias(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ISubqueryWithJoin WithAlias(TableAlias tableAlias)
        {
            throw new NotImplementedException();
        }
    }
}
