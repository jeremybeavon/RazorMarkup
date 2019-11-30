namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeTargetTable : AbstractStatement<MergeStatementBuilder>, IMergeTargetTable
    {
        public MergeTargetTable(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeWithHint Table(TableName tableName)
        {
            Statement.TableName = tableName.ToSqlString();
            Statement.Append((IMergeTargetTable input) => input.Table(null), tableName);
            return new MergeWithHint(Statement);
        }

        public IMergeWithHint View(ViewName viewName)
        {
            Statement.TableName = viewName.ToSqlString();
            Statement.Append((IMergeTargetTable input) => input.View(null), viewName);
            return new MergeWithHint(Statement);
        }
    }
}
