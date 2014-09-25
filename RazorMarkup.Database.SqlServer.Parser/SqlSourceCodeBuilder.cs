using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    public sealed class SqlSourceCodeBuilder
    {
        public static ISqlString ToSqlString(string text)
        {
            TSql120Parser parser = new TSql120Parser(false);
            using (TextReader reader = new StringReader(text))
            {
                IList<ParseError> errors;
                TSqlFragment fragment = parser.Parse(reader, out errors);
                SqlSourceCodeVisitor visitor = new SqlSourceCodeVisitor();
                fragment.Accept(visitor);
                return visitor.Result;
            }
        }
    }
}
