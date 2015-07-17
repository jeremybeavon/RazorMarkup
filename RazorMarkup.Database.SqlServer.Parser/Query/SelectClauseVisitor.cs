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
            ISelectColumn<TEndType> selectColumn = null;
            ColumnReferenceExpression columnReference = node.Expression as ColumnReferenceExpression;
            if (columnReference != null)
            {
                if (columnReference.ColumnType == ColumnType.PseudoColumnIdentity)
                {
                    selectColumn = columnReference.MultiPartIdentifier == null ?
                        selectClause.IdentityColumn() :
                        selectClause.IdentityColumn(columnReference.MultiPartIdentifier.ToTableName());
                }
                else if (columnReference.ColumnType == ColumnType.PseudoColumnRowGuid)
                {
                    selectColumn = columnReference.MultiPartIdentifier == null ?
                        selectClause.RowGuidColumn() :
                        selectClause.RowGuidColumn(columnReference.MultiPartIdentifier.ToTableName());
                }
            }
            else
            {
                UserDefinedTypePropertyAccess propertyAccess = node.Expression as UserDefinedTypePropertyAccess;
                if (propertyAccess != null)
                {
                    selectColumn = selectClause
                        .ClrColumn(((UserDefinedTypeCallTarget)propertyAccess.CallTarget).SchemaObjectName.ToClrColumnName())
                        .StaticProperty(new ClrPropertyName(propertyAccess.PropertyName.Value));
                }
            }

            if (selectColumn == null)
            {
                selectColumn = selectClause.Column(node.Expression.ToExpression<object>());
            }

            Result = node.ColumnName == null ? selectColumn : selectColumn.As(node.ColumnName.ToColumnAlias());
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
