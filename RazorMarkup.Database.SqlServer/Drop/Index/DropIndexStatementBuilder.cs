using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexStatementBuilder : AbstractStatementBuilder
    {
        public DropIndexStatementBuilder(IndexName indexName)
        {
            Indexes = new List<DropSingleIndexStatementBuilder>(new[] { new DropSingleIndexStatementBuilder(indexName) });
        }

        public IList<DropSingleIndexStatementBuilder> Indexes { get; private set; }

        public DropSingleIndexStatementBuilder CurrentIndex
        {
            get { return Indexes.Last(); }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("DROP INDEX ");
            Indexes[0].ToSqlString(sqlBuilder);
        }
    }
}
