using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Parser.Query.Select
{
    internal sealed class SelectClauseVisitor<TEndType> : AbstractSqlVisitor<ISelectClauseWithInto<TEndType>>
    {
        private ISelectClause<TEndType> selectClause;

        public SelectClauseVisitor(ISelectClause<TEndType> selectClause, IEnumerable<SelectElement> selectElements)
        {
            this.selectClause = selectClause;
            foreach (SelectElement selectElement in selectElements)
            {
                selectElement.Accept(this);
            }
        }

        public override void Visit(SelectScalarExpression node)
        {
            ISelectColumn<TEndType> column = selectClause.Column(node.Expression.ToExpression<object>());
            Result = column;
            selectClause = column;
        }

        public override void Visit(SelectStarExpression node)
        {
            throw new NotSupportedException();
        }

        public override void Visit(SelectSetVariable node)
        {
            throw new NotSupportedException();
        }
    }
}
