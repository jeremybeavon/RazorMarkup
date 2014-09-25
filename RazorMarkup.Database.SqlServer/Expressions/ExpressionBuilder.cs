using System;
using System.Linq.Expressions;
using RazorMarkup.Common;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    internal sealed class ExpressionBuilder : AbstractExpressionVisitor
    {
        private readonly SqlBuilder sqlBuilder;

        public ExpressionBuilder(SqlBuilder sqlBuilder)
        {
            this.sqlBuilder = sqlBuilder;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            switch (Type.GetTypeCode(node.Type))
            {
                case TypeCode.DBNull:
                case TypeCode.Empty:
                    sqlBuilder.Append("NULL");
                    break;
                case TypeCode.Boolean:
                    sqlBuilder.Append((bool)node.Value ? "1" : "0");
                    break;
                case TypeCode.Char:
                case TypeCode.String:
                    sqlBuilder.Append("'");
                    sqlBuilder.Append(node.Value.ToString().Replace("'", "''"));
                    sqlBuilder.Append("'");
                    break;
                case TypeCode.DateTime:
                    throw new NotSupportedException();
                case TypeCode.Object:
                    throw new NotSupportedException();
                default:
                    sqlBuilder.Append(node.Value.ToString());
                    break;
            }

            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            FunctionRegistrationManager.Instance.GetFunctionBuilder(node.Method).ToSqlString(sqlBuilder);
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.IsImplicitOperator())
            {
                Visit(node.Operand);
                return node;
            }

            return base.VisitUnary(node);
        }
    }
}
