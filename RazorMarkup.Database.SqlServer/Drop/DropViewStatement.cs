namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropViewStatement : SqlBuilder, IDropViewStatement
    {
        public DropViewStatement(ViewName viewName)
            : base(string.Format("DROP VIEW {0}", viewName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().View(null), viewName);
        }

        public IDropViewStatement And(ViewName viewName)
        {
            Append(", ");
            Append(viewName.ToSqlString());
            Append((IDropViewStatement input) => input.And(null), viewName);
            return this;
        }
    }
}
