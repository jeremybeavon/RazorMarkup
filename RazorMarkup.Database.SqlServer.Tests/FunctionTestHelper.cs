using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Tests
{
    internal static class FunctionTestHelper
    {
        public static void TestFunction(Expression<Func<object>> expression, string expectedSql)
        {
            Sql.Query().Select().Column(expression).End().Query().ToSqlStringViaRazorPageIs("SELECT " + expectedSql);
        }
    }
}
