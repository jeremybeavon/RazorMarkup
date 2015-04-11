using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class SelectClauseVisitor<TEndType> : AbstractSqlVisitor<ISelectClauseWithInto<TEndType>>
    {
        private ISelectClause<TEndType> selectClause;

        public SelectClauseVisitor(ISelectClause<TEndType> selectClause)
        {
            this.selectClause = selectClause;
        }

        public override void ExplicitVisit(SelectScalarExpression node)
        {
            ISelectColumn<TEndType> column = selectClause.Column(node.Expression.ToExpression<object>());
            Result = column;
            selectClause = column;
        }

        public override void ExplicitVisit(SelectStarExpression node)
        {
            throw new NotSupportedException();
        }

        public override void ExplicitVisit(SelectSetVariable node)
        {
            throw new NotSupportedException();
        }
    }
}
