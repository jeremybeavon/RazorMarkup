using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class SelectClauseVisitor<TEndType> : AbstractSqlVisitor<ISelectClauseAnd<TEndType>>
    {
        private readonly ISelectClause<TEndType> selectClause;

        public SelectClauseVisitor(ISelectClause<TEndType> selectClause)
        {
            this.selectClause = selectClause;
        }

        public override void ExplicitVisit(SelectScalarExpression node)
        {
            Result = selectClause.Column(node.Expression.ToExpression<object>());
        }

        public override void ExplicitVisit(SelectStarExpression node)
        {
            Result = node.Qualifier == null ? selectClause.AllColumns() : selectClause.AllColumns(node.Qualifier.ToTableName());
        }

        public override void ExplicitVisit(SelectSetVariable node)
        {
            throw new NotSupportedException();
        }
    }
}
