using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Expressions;
using RazorMarkup.Database.SqlServer.Query.Select;
using SqlSubquery = RazorMarkup.Database.SqlServer.Subquery;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryExpressionBuilder : ClauseBuilder
    {
        public SubqueryExpressionBuilder()
            : base(null)
        {
        }

        public SubqueryBuilder Subquery
        {
            get
            {
                if (NextClause != null)
                {
                    return (SubqueryBuilder)NextClause;
                }

                Initialize(() => SqlSubquery.Select());
                SubqueryBuilder builder = new SubqueryBuilder(Expression);
                builder.Select.NextClause = new SelectClauseBuilder(Expression);
                NextClause = builder;
                return builder;
            }
        }

        public QueryOperatorGroupBuilder QueryOperatorGroup
        {
            get
            {
                if (NextClause != null)
                {
                    return (QueryOperatorGroupBuilder)NextClause;
                }

                Initialize(() => SqlSubquery.BeginOperatorGroup());
                QueryOperatorGroupBuilder builder = new QueryOperatorGroupBuilder(Expression);
                NextClause = builder;
                return builder;
            }
        }
    }
}
