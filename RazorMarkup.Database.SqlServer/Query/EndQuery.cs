using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class EndQuery : IEndQuery
    {
        private readonly QueryStatements query;

        public EndQuery(QueryStatements query)
        {
            this.query = query;
        }

        public ISqlString Query()
        {
            query.EndQuery();
            return query;
        }
    }
}
