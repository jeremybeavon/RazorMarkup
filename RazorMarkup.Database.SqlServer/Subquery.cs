﻿using RazorMarkup.Database.SqlServer.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer
{
    public static class Subquery
    {
        public static ISelectClauseWithDistinct<IEndSubquery> Select()
        {
            SubqueryExpressionBuilder builder = new SubqueryExpressionBuilder();
            SelectClauseBuilder selectClauseBuilder = (SelectClauseBuilder)builder.Subquery.Select.NextClause;
            return new SelectClauseWithDistinct<IEndSubquery>(selectClauseBuilder, new EndSubquery(builder));
        }

        public static IQueryOperand<IQueryOperatorGroupEnd<IEndSubquery>> BeginOperatorGroup()
        {
            SubqueryExpressionBuilder builder = new SubqueryExpressionBuilder();
            return new QueryOperand<IQueryOperatorGroupEnd<IEndSubquery>>(
                builder.QueryOperatorGroup,
                new QueryOperatorGroupEnd<IEndSubquery>(builder.QueryOperatorGroup.Expression, new EndSubquery(builder)));
        }
    }
}
