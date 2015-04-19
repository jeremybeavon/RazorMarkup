using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Expressions.Functions;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    internal sealed class ExpressionBuilder : AbstractExpressionVisitor
    {
        private static readonly IDictionary<ExpressionType, Action<SqlBuilder>> binaryExpressions =
            new Dictionary<ExpressionType, Action<SqlBuilder>>()
        {
            { ExpressionType.Add, builder => builder.Append(" + ") },
            { ExpressionType.AddChecked, builder => builder.Append(" + ") },
            { ExpressionType.And, builder => builder.Append(" & ") },
            { ExpressionType.AndAlso, builder => builder.AppendIndent().Append("AND ") },
            { ExpressionType.Divide, builder => builder.Append(" / ") },
            { ExpressionType.Equal, builder => builder.Append(" = ") },
            { ExpressionType.ExclusiveOr, builder => builder.Append(" ^ ") },
            { ExpressionType.GreaterThan, builder => builder.Append(" > ") },
            { ExpressionType.GreaterThanOrEqual, builder => builder.Append(" >= ") },
            { ExpressionType.LeftShift, builder => builder.Append(" << ") },
            { ExpressionType.LessThan, builder => builder.Append(" < ") },
            { ExpressionType.LessThanOrEqual, builder => builder.Append(" <= ") },
            { ExpressionType.Modulo, builder => builder.Append(" % ") },
            { ExpressionType.Multiply, builder => builder.Append(" * ") },
            { ExpressionType.MultiplyChecked, builder => builder.Append(" * ") },
            { ExpressionType.NotEqual, builder => builder.Append(" != ") },
            { ExpressionType.Or, builder => builder.Append(" | ") },
            { ExpressionType.OrElse, builder => builder.AppendIndent().Append("OR ") },
            { ExpressionType.RightShift, builder => builder.Append(" >> ") },
            { ExpressionType.Subtract, builder => builder.Append(" - ") },
            { ExpressionType.SubtractChecked, builder => builder.Append(" - ") }
        };
        private readonly SqlBuilder sqlBuilder;

        public ExpressionBuilder(SqlBuilder sqlBuilder)
        {
            this.sqlBuilder = sqlBuilder;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Action<SqlBuilder> sqlBuilderAction;
            if (binaryExpressions.TryGetValue(node.NodeType, out sqlBuilderAction))
            {
                Visit(node.Left);
                sqlBuilderAction(sqlBuilder);
                Visit(node.Right);
            }
            else if (node.NodeType == ExpressionType.Coalesce)
            {
                VisitCoalesce(node);
            }
            else
            {
                throw new NotSupportedException();
            }

            return null;
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
                    if (node.Value == null)
                    {
                        sqlBuilder.Append("NULL");
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }

                    break;
                default:
                    sqlBuilder.Append(node.Value.ToString());
                    break;
            }

            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            if (typeof(ISqlString).IsAssignableFrom(node.Type))
            {
                sqlBuilder.Append(((ConstantExpression)node.Arguments[0]).Value.ToString());
            }
            else
            {
                throw new NotSupportedException();
            }

            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            AbstractStatementBuilder statement = FunctionRegistrationManager.Instance.GetFunctionBuilder(node.Method);
            FunctionBuilder functionBuilder = statement as FunctionBuilder;
            if (functionBuilder != null)
            {
                foreach (Expression parameter in node.Arguments)
                {
                    functionBuilder.Arguments.Add(new ParameterBuilder(parameter));
                }
            }

            statement.ToSqlString(sqlBuilder);
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

        private void VisitCoalesce(BinaryExpression node)
        {
            sqlBuilder.Append("COALESCE(");
            Visit(node.Left);
            sqlBuilder.Append(", ");
            Visit(node.Right);
            sqlBuilder.Append(")");
        }
    }
}
