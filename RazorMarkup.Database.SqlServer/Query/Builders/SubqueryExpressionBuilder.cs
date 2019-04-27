using SqlSubquery = RazorMarkup.Database.SqlServer.Subquery;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryExpressionBuilder : ClauseBuilder
    {
        public SubqueryExpressionBuilder()
            : base(new ExpressionBuilder())
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
                SubqueryBuilder builder = new SubqueryBuilder(ExpressionBuilder);
                builder.Select.NextClause = new SelectClauseBuilder(ExpressionBuilder);
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
                QueryOperatorGroupBuilder builder = new QueryOperatorGroupBuilder(ExpressionBuilder);
                NextClause = builder;
                return builder;
            }
        }
    }
}
