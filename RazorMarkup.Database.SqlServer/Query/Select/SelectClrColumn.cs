using System;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClrColumn<TEndType> : SelectColumn<TEndType>, ISelectClrColumn<TEndType>
    {
        public SelectClrColumn(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectColumn<TEndType> Field(ClrFieldName field)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "." + field.ToSqlString();
            Statement.Append((ISelectClrColumn<TEndType> input) => input.Field(null), field);
            return this;
        }

        public ISelectColumn<TEndType> Property(ClrPropertyName property)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "." + property.ToSqlString();
            Statement.Append((ISelectClrColumn<TEndType> input) => input.Property(null), property);
            return this;
        }

        public ISelectColumn<TEndType> StaticField(ClrFieldName field)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "::" + field.ToSqlString();
            Statement.Append((ISelectClrColumn<TEndType> input) => input.StaticField(null), field);
            return this;
        }

        public ISelectColumn<TEndType> StaticProperty(ClrPropertyName property)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "::" + property.ToSqlString();
            Statement.Append((ISelectClrColumn<TEndType> input) => input.StaticProperty(null), property);
            return this;
        }

        public ISelectColumn<TEndType> Method(ClrMethodName method, params Expression<Func<object>>[] parameters)
        {
            ExpressionBuilder<object>[] parameterBuilders = parameters.Select(parameter => parameter.ToExpressionBuilder()).ToArray();
            string parameterText = string.Join(", ", parameterBuilders.Select(parameter => parameter.ToSqlString()));
            Statement.Columns.Last().ColumnName += "." + method.ToSqlString() + "(" + parameterText + ")";
            SqlStringArray parameterExpressions = new SqlStringArray(typeof(Expression<Func<object>>), parameterBuilders);
            Statement.Append((ISelectClrColumn<TEndType> input) => input.Method(null), method, parameterExpressions);
            return this;
        }

        public ISelectColumn<TEndType> StaticMethod(ClrMethodName method, params Expression<Func<object>>[] parameters)
        {
            ExpressionBuilder<object>[] parameterBuilders = parameters.Select(parameter => parameter.ToExpressionBuilder()).ToArray();
            string parameterText = string.Join(", ", parameterBuilders.Select(parameter => parameter.ToSqlString()));
            Statement.Columns.Last().ColumnName += "::" + method.ToSqlString() + "(" + parameterText + ")";
            SqlStringArray parameterExpressions = new SqlStringArray(typeof(Expression<Func<object>>), parameterBuilders);
            Statement.Append((ISelectClrColumn<TEndType> input) => input.StaticMethod(null), method, parameterExpressions);
            return this;
        }
    }
}
