using System;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Expressions;
using BinaryExpression = Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression;
using SqlStringLiteral = Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral;
using UnaryExpression = Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlExpressionVisitor : AbstractSqlVisitor<Expression>
    {
        private static readonly ConstructorInfo variableNameConstructor =
            typeof(VariableName).GetConstructor(new Type[] { typeof(string) });

        public override void ExplicitVisit(BinaryExpression node)
        {
            Expression left = BuildResult(node.FirstExpression);
            Expression right = BuildResult(node.SecondExpression);
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

        public override void ExplicitVisit(GlobalVariableExpression node)
        {
            Result = Expression.Call(FunctionRegistrationManager.Instance.GetMethod(node.Name));
        }

        public override void ExplicitVisit(SqlStringLiteral node)
        {
            Result = Expression.Constant(node.Value);
        }

        public override void ExplicitVisit(UnaryExpression node)
        {
            Expression operand = BuildResult(node.Expression);
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
