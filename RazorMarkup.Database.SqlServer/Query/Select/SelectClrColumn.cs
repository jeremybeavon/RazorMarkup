using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClrColumn<TEndType> : SelectColumn<TEndType>, ISelectClrColumn<TEndType>
    {
        public SelectClrColumn(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithFrom<TEndType> Field(ClrFieldName field)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "." + field.ToSqlString();
            return this;
        }

        public ISelectClauseWithFrom<TEndType> Property(ClrPropertyName property)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "." + property.ToSqlString();
            return this;
        }

        public ISelectClauseWithFrom<TEndType> StaticField(ClrFieldName field)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "::" + field.ToSqlString();
            return this;
        }

        public ISelectClauseWithFrom<TEndType> StaticProperty(ClrPropertyName property)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "::" + property.ToSqlString();
            return this;
        }

        public ISelectClauseWithFrom<TEndType> Method(ClrMethodName method, params string[] parameters)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "." + method.ToSqlString() + string.Join(", ", parameters);
            return this;
        }

        public ISelectClauseWithFrom<TEndType> StaticMethod(ClrMethodName method, params string[] parameters)
        {
            Statement.Columns[Statement.Columns.Count - 1].ColumnName += "::" + method.ToSqlString() + string.Join(", ", parameters);
            return this;
        }
    }
}
