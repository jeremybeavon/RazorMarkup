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
            ISelectColumn<TEndType> selectColumn =
                MatchIdentityOrRowGuidColumn(node.Expression) ??
                MatchStaticClrColumnProperty(node.Expression) ??
                MatchClrColumnMethod(node.Expression) ??
                MatchColumn(node.Expression);
            Result = node.ColumnName == null ? selectColumn : selectColumn.As(node.ColumnName.ToColumnAlias());
        }

        public override void ExplicitVisit(SelectStarExpression node)
        {
            Result = node.Qualifier == null ? selectClause.AllColumns() : selectClause.AllColumns(node.Qualifier.ToTableName());
        }

        public override void ExplicitVisit(SelectSetVariable node)
        {
            Result = selectClause.Column(new ColumnAlias(node.Variable.Name), node.Expression.ToExpression<object>());
        }

        private ISelectColumn<TEndType> MatchIdentityOrRowGuidColumn(ScalarExpression node)
        {
            ColumnReferenceExpression columnReference = node as ColumnReferenceExpression;
            if (columnReference == null)
            {
                return null;
            }

            if (columnReference.ColumnType == ColumnType.PseudoColumnIdentity)
            {
                return columnReference.MultiPartIdentifier == null ?
                    selectClause.IdentityColumn() :
                    selectClause.IdentityColumn(columnReference.MultiPartIdentifier.ToTableName());
            }
            
            if (columnReference.ColumnType == ColumnType.PseudoColumnRowGuid)
            {
                return columnReference.MultiPartIdentifier == null ?
                    selectClause.RowGuidColumn() :
                    selectClause.RowGuidColumn(columnReference.MultiPartIdentifier.ToTableName());
            }

            return null;
        }

        private ISelectColumn<TEndType> MatchStaticClrColumnProperty(ScalarExpression node)
        {
            UserDefinedTypePropertyAccess propertyAccess = node as UserDefinedTypePropertyAccess;
            if (propertyAccess != null)
            {
                return selectClause
                    .ClrColumn(((UserDefinedTypeCallTarget)propertyAccess.CallTarget).SchemaObjectName.ToClrColumnName())
                    .StaticProperty(new ClrPropertyName(propertyAccess.PropertyName.Value));
            }

            return null;
        }

        private ISelectColumn<TEndType> MatchClrColumnMethod(ScalarExpression node)
        {
            FunctionCall functionCall = node as FunctionCall;
            if (functionCall == null)
            {
                return null;
            }

            MultiPartIdentifierCallTarget callTarget = functionCall.CallTarget as MultiPartIdentifierCallTarget;
            if (callTarget == null)
            {
                UserDefinedTypeCallTarget staticMethodCallTarget = functionCall.CallTarget as UserDefinedTypeCallTarget;
                if (staticMethodCallTarget == null)
                {
                    return null;
                }

                return selectClause
                    .ClrColumn(staticMethodCallTarget.SchemaObjectName.ToClrColumnName())
                    .StaticMethod(new ClrMethodName(functionCall.FunctionName.Value), functionCall.Parameters.ToExpressions<object>());
            }

            return selectClause
                .ClrColumn(callTarget.MultiPartIdentifier.ToClrColumnName())
                .Method(new ClrMethodName(functionCall.FunctionName.Value), functionCall.Parameters.ToExpressions<object>());
        }

        private ISelectColumn<TEndType> MatchColumn(ScalarExpression node)
        {
            return selectClause.Column(node.ToExpression<object>());
        }
    }
}
