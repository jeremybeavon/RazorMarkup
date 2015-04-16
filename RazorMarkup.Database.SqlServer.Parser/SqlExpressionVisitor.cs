using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Expressions;
using BinaryExpression = Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression;
using SqlIntegerLiteral = Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral;
using SqlStringLiteral = Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral;
using UnaryExpression = Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlExpressionVisitor : AbstractSqlVisitor<Expression>
    {
        private static readonly ConstructorInfo columnNameConstructor =
            typeof(ColumnName).GetConstructor(new Type[] { typeof(string) });

        private static readonly ConstructorInfo variableNameConstructor =
            typeof(VariableName).GetConstructor(new Type[] { typeof(string) });

        private readonly Type type;

        public SqlExpressionVisitor()
        {
        }

        public SqlExpressionVisitor(Type type)
        {
            this.type = type;
        }

        public static Expression<Func<TResult>> ToExpression<TResult>(TSqlFragment expression)
        {
            Expression body = expression.AcceptWithResult(new SqlExpressionVisitor());
            if (body.Type != typeof(TResult))
            {
                body = Expression.Convert(body, typeof(TResult));
            }

            return Expression.Lambda<Func<TResult>>(body);
        }

        public override void ExplicitVisit(BinaryExpression node)
        {
            Expression left = node.FirstExpression.AcceptWithResult(this);
            Expression right = node.SecondExpression.AcceptWithResult(this);
            switch (node.BinaryExpressionType)
            {
                case BinaryExpressionType.Add:
                    Result = Expression.Add(left, right);
                    break;
                case BinaryExpressionType.Subtract:
                    Result = Expression.Subtract(left, right);
                    break;
                case BinaryExpressionType.Multiply:
                    Result = Expression.Multiply(left, right);
                    break;
                case BinaryExpressionType.Divide:
                    Result = Expression.Divide(left, right);
                    break;
                case BinaryExpressionType.Modulo:
                    Result = Expression.Modulo(left, right);
                    break;
                case BinaryExpressionType.BitwiseAnd:
                    Result = Expression.And(left, right);
                    break;
                case BinaryExpressionType.BitwiseOr:
                    Result = Expression.Or(left, right);
                    break;
                case BinaryExpressionType.BitwiseXor:
                    Result = Expression.ExclusiveOr(left, right);
                    break;
            }
        }

        public override void ExplicitVisit(BooleanComparisonExpression node)
        {
            Expression left = node.FirstExpression.AcceptWithResult(this);
            Expression right = node.SecondExpression.AcceptWithResult(this);
            switch (node.ComparisonType)
            {
                case BooleanComparisonType.Equals:
                    Result = Expression.Equal(left, right);
                    break;
                case BooleanComparisonType.GreaterThan:
                    Result = Expression.GreaterThan(left, right);
                    break;
                case BooleanComparisonType.LessThan:
                    Result = Expression.LessThan(left, right);
                    break;
                case BooleanComparisonType.GreaterThanOrEqualTo:
                    Result = Expression.GreaterThanOrEqual(left, right);
                    break;
                case BooleanComparisonType.LessThanOrEqualTo:
                    Result = Expression.LessThanOrEqual(left, right);
                    break;
                case BooleanComparisonType.NotEqualToBrackets:
                case BooleanComparisonType.NotEqualToExclamation:
                    Result = Expression.NotEqual(left, right);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public override void ExplicitVisit(ColumnReferenceExpression node)
        {
            Result = Expression.New(columnNameConstructor, Expression.Constant(node.ToColumnNameText()));
        }

        public override void ExplicitVisit(FunctionCall node)
        {
            MethodInfo method = FunctionRegistrationManager.Instance.GetMethod(node.FunctionName.Value, node.Parameters.Count);
            Type[] parameterTypes = method.GetParameters().Select(parameter => parameter.ParameterType).ToArray();
            Func<ScalarExpression, int, Expression> getParameterFunc =
                (parameter, index) => parameter.AcceptWithResult(new SqlExpressionVisitor(parameterTypes[index]));
            Result = Expression.Call(method, node.Parameters.Select(getParameterFunc));
        }

        public override void ExplicitVisit(GlobalVariableExpression node)
        {
            Result = Expression.Call(FunctionRegistrationManager.Instance.GetMethod(node.Name, 0));
        }

        public override void ExplicitVisit(NullLiteral node)
        {
            Result = type == null ? Expression.Constant(null): Expression.Constant(null, type);
        }

        public override void ExplicitVisit(ParenthesisExpression node)
        {
            Result = node.Expression.AcceptWithResult(new SqlExpressionVisitor());
        }

        public override void ExplicitVisit(SqlIntegerLiteral node)
        {
            Result = Expression.Constant(int.Parse(node.Value));
        }

        public override void ExplicitVisit(SqlStringLiteral node)
        {
            Result = Expression.Constant(node.Value);
        }

        public override void ExplicitVisit(UnaryExpression node)
        {
            Expression operand = node.Expression.AcceptWithResult(this);
            switch (node.UnaryExpressionType)
            {
                case UnaryExpressionType.Positive:
                    Result = Expression.UnaryPlus(operand);
                    break;
                case UnaryExpressionType.Negative:
                    Result = Expression.Negate(operand);
                    break;
                case UnaryExpressionType.BitwiseNot:
                    Result = Expression.Not(operand);
                    break;
            }
        }

        public override void ExplicitVisit(VariableReference node)
        {
            Result = Expression.New(variableNameConstructor, Expression.Constant(node.Name));
        }
    }
}
