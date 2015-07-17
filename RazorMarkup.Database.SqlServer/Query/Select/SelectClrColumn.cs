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
            ExpressionBuilder<object>[] parameterExpressions = parameters.Select(parameter => parameter.ToExpressionBuilder()).ToArray();
            Statement.Columns[Statement.Columns.Count - 1].ColumnName +=
                "." + method.ToSqlString() + string.Join(", ", parameterExpressions.Select(parameter => parameter.ToSqlString()));
            Statement.Append(
                (ISelectClrColumn<TEndType> input) => input.Method(null),
                (new ISqlString[] { method }).Concat(parameterExpressions).ToArray());
            return this;
        }

        public ISelectColumn<TEndType> StaticMethod(ClrMethodName method, params Expression<Func<object>>[] parameters)
        {
            ExpressionBuilder<object>[] parameterExpressions = parameters.Select(parameter => parameter.ToExpressionBuilder()).ToArray();
            Statement.Columns[Statement.Columns.Count - 1].ColumnName +=
                "::" + method.ToSqlString() + string.Join(", ", parameterExpressions.Select(parameter => parameter.ToSqlString()));
            Statement.Append(
                (ISelectClrColumn<TEndType> input) => input.StaticMethod(null),
                (new ISqlString[] { method }).Concat(parameterExpressions).ToArray());
            return this;
        }
    }
}
