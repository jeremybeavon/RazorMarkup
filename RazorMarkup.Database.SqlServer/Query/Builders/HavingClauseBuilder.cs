﻿using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class HavingClauseBuilder : ClauseBuilder
    {
        public HavingClauseBuilder(ExpressionBuilder expressionBuilder, Expression<Func<bool>> searchCondition)
            : base(expressionBuilder)
        {
            SearchCondition = new ExpressionBuilder<bool>(searchCondition);
        }

        public ExpressionBuilder<bool> SearchCondition { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("HAVING ");
            SearchCondition.ToSqlString(sqlBuilder);
            base.ToSqlString(sqlBuilder);
        }
    }
}
