using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeNotMatched : AbstractStatement<MergeStatementBuilder>, IMergeNotMatched
    {
        public MergeNotMatched(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeNotMatchedInsert Insert(params ColumnName[] columnNames)
        {
            Statement.LastNotMatchedClause.ColumnNames.AddRange(columnNames.Select(name => name.ToSqlString()));
            Statement.Append((IMergeNotMatched input) => input.Insert(), columnNames);
            return null;
        }
    }
}
