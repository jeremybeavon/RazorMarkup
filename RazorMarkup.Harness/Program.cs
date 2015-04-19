using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Parser;
using RazorMarkup.Database.SqlServer;

namespace RazorMarkup.Harness
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CodeGenerator.GenerateSystemViews(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=\"New Database\";Integrated Security=True;",
                "RazorMarkup.Database.SqlServer.System.Views",
                @"C:\Users\beavon\Documents\Visual Studio 2013\Projects\RazorMarkup\RazorMarkup.Database.SqlServer\System\Views");
        }
    }
}
