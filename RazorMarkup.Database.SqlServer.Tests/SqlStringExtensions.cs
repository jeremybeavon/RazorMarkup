using FluentAssertions;
using RazorMarkup.Common;
using RazorMarkup.Database.SqlServer.Parser;

namespace RazorMarkup.Database.SqlServer.Tests
{
    public static class SqlStringExtensions
    {
        public const string DummyFileName = "TestPage.cshtml";

        public static string ToSqlStringViaRazorPage(this ISqlString sqlString)
        {
            return SqlSourceCodeBuilder.ToSqlString(sqlString.ToSqlString()).ToSourceCode().ToRazorPage(DummyFileName).Render();
        }

        public static void Matches(this ISqlString sqlString, string expectedSql)
        {
            sqlString.ToSqlStringViaRazorPage().Trim().Should().Be(expectedSql);
        }
    }
}
