using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class SubqueryWithAlias<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>,
        ISubqueryWithAlias<TEndType>
    {
        public SubqueryWithAlias(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISubqueryWithJoin<TEndType> WithAlias(TableAlias tableAlias)
        {
            throw new NotImplementedException();
        }
    }
}
