namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropTableStatement : SqlBuilder, IDropTableStatement
    {
        public DropTableStatement(TableName tableName)
            : base(string.Format("DROP TABLE {0}", tableName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().Table(null), tableName);
        }

        public IDropTableStatement And(TableName tableName)
        {
            Append(", ");
            Append(tableName.ToSqlString());
            Append((IDropTableStatement input) => input.And(null), tableName);
            return this;
        }
    }
}
