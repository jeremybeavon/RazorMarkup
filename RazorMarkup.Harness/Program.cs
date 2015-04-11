using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Parser;

namespace RazorMarkup.Harness
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SqlSourceCodeBuilder.ToSqlString("SELECT * FROM test2 ORDER BY col1 OFFSET 1 ROW FETCH NEXT 2 ROWS ONLY");
        }
    }
}
