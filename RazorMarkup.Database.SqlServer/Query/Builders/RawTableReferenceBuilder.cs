using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class RawTableReferenceBuilder : AbstractTableReferenceBuilder
    {
        private readonly string sql;

        public RawTableReferenceBuilder(string sql)
            : base(null)
        {
            this.sql = sql;
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(sql);
        }
    }
}
