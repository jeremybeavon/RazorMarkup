using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class RawTableReferenceBuilder : AbstractTableReferenceBuilder
    {
        private readonly string sql;

        public RawTableReferenceBuilder(string sql)
        {
            this.sql = sql;
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(sql);
        }
    }
}
