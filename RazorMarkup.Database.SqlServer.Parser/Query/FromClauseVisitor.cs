using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class FromClauseVisitor<TEndType> : AbstractSqlVisitor<IEndFromClause<TEndType>>
    {
        private readonly IFromClause<TEndType> fromClause;

        public FromClauseVisitor(IFromClause<TEndType> fromClause)
        {
            this.fromClause = fromClause;
        }


    }
}
