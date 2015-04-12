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
            SqlSourceCodeBuilder.ToSqlString("SELECT * FROM test2 PIVOT (COUNT(column1) FOR column2 IN (test1)) AS testPivot");
        }
    }
}
