﻿using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpressionQuery : AbstractCommonTableExpression, IQueryOperand<ICommonTableExpressionEnd>
    {
        public CommonTableExpressionQuery(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithDistinct<ICommonTableExpressionEnd> Select()
        {
            Statement.Append((IQueryOperand<ICommonTableExpressionEnd> input) => input.Select());
            CommonTableExpressionEnd end = new CommonTableExpressionEnd(Statement, EndClosure);
            return new SelectClauseWithDistinct<ICommonTableExpressionEnd>(ExpressionBuilder, end).AsNextClause(Statement.LastExpression);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<ICommonTableExpressionEnd>> BeginOperatorGroup()
        {
            Statement.Append((IQueryOperand<ICommonTableExpressionEnd> input) => input.BeginOperatorGroup());
            ICommonTableExpressionEnd end = new CommonTableExpressionEnd(Statement, EndClosure);
            return new QueryOperatorGroupEnd<ICommonTableExpressionEnd>(ExpressionBuilder, end).AsOperand().AsNextClause(Statement.LastExpression);
        }
    }
}
