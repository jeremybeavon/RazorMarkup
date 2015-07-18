using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    internal sealed class DropSignatureStatementBuilder : AbstractStatementBuilder
    {
        private readonly StringBuilder textBuilder;
        private string comma;

        public DropSignatureStatementBuilder(string moduleName)
            : base(new ExpressionBuilder())
        {
            textBuilder = new StringBuilder(string.Format("DROP SIGNATURE FROM {0} BY ", moduleName));
            comma = string.Empty;
        }

        public void Append(string text)
        {
            textBuilder.Append(comma);
            comma = ", ";
            textBuilder.Append(text);
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(textBuilder.ToString());
        }
    }
}
