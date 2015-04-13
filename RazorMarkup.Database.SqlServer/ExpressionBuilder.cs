﻿using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Expressions;

namespace RazorMarkup.Database.SqlServer
{
    internal sealed class ExpressionBuilder<TResult> : AbstractStatementBuilder
    {
        public ExpressionBuilder(Expression<Func<TResult>> expression)
            : base(expression)
        {
            OriginalExpression = expression;
        }

        public Expression<Func<TResult>> OriginalExpression { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            new ExpressionBuilder(sqlBuilder).Visit(OriginalExpression.Body);
        }
    }
}