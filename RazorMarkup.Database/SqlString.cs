using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public class SqlString : ISqlString
    {
        private readonly string sqlString;

        public SqlString(string sqlString)
        {
            this.sqlString = sqlString;
            Parameters = new List<ISqlString>();
        }

        public SqlString(string sqlString, Expression expression)
            : this(sqlString)
        {
            Expression = expression;
        }

        public SqlString(string sqlString, Expression<Func<ISqlString>> createFunc, params ISqlString[] parameters)
        {
            this.sqlString = sqlString;
            CreateFunc = createFunc;
            Parameters = parameters;
        }

        public Expression<Func<ISqlString>> CreateFunc { get; set; }

        public IList<ISqlString> Parameters { get; set; }

        public Expression Expression { get; set; }

        public static SqlString Create<TResult>(
            string sqlString,
            Expression<Func<ISqlString>> expression,
            Expression<Func<TResult>> parameter)
        {
            return new SqlString(sqlString, ExpressionBuilder.BuildExpression(expression, parameter));
        }

        public virtual Expression ToExpression()
        {
            if (Expression != null)
            {
                return Expression;
            }

            if (CreateFunc != null)
            {
                return ExpressionBuilder.BuildExpression(CreateFunc, Parameters);
            }

            return Expression.New(GetType().GetConstructor(new Type[] { typeof(string) }), Expression.Constant(sqlString));
        }

        public string ToSqlString()
        {
            return sqlString;
        }

        public override string ToString()
        {
            return ToSqlString();
        }

    }
}
