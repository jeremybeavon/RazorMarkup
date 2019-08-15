using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal sealed class SetColumnOrVariableBuilder : AbstractStatementBuilder
    {
        public SetColumnOrVariableBuilder(ExpressionBuilder expressionBuilder) 
            : base(expressionBuilder)
        {
            Operator = "=";
        }

        public string VariableName { get; set; }

        public string ColumnName { get; set; }

        public string FieldOrPropertyName { get; set; }

        public string MethodName { get; set; }

        public List<ExpressionBuilder<object>> MethodArguments { get; } = new List<ExpressionBuilder<object>>();

        public ExpressionBuilder<object> WriteExpression { get; set; }

        public string WriteOffset { get; set; }

        public string WriteLength { get; set; }

        public string Operator { get; set; }

        public ExpressionBuilder<object> Expression { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (VariableName != null)
            {
                sqlBuilder.Append(VariableName);
                if (ColumnName != null)
                {
                    sqlBuilder.Append(" = ");
                }
            }

            if (ColumnName != null)
            {
                sqlBuilder.Append(ColumnName);
            }

            if (FieldOrPropertyName != null)
            {
                sqlBuilder.Append(".");
                sqlBuilder.Append(FieldOrPropertyName);
                sqlBuilder.Append(" = ");
                Expression.ToSqlString(sqlBuilder);
            }
            else if (MethodName != null)
            {
                sqlBuilder.Append(".");
                sqlBuilder.Append(MethodName);
                sqlBuilder.Append("(");
                bool isFirst = true;
                foreach (ExpressionBuilder<object> methodArgument in MethodArguments)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        sqlBuilder.Append(", ");
                    }

                    methodArgument.ToSqlString(sqlBuilder);
                }

                sqlBuilder.Append(")");
            }
            else if (Expression != null)
            {
                sqlBuilder.Append(" ");
                sqlBuilder.Append(Operator);
                sqlBuilder.Append(" ");
                Expression.ToSqlString(sqlBuilder);
            }
            else if (WriteExpression != null)
            {
                sqlBuilder.Append(".WRITE(");
                WriteExpression.ToSqlString(sqlBuilder);
                sqlBuilder.Append(", ");
                sqlBuilder.Append(WriteOffset);
                sqlBuilder.Append(", ");
                sqlBuilder.Append(WriteLength);
                sqlBuilder.Append(")");
            }
        }
    }
}
