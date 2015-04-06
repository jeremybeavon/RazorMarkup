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
            string text = sqlString.ToSqlString();
            ISqlString sqlText = SqlSourceCodeBuilder.ToSqlString(text);
            ISourceCode sourceCode = sqlText.ToSourceCode();
            IRazorPage razorPage = sourceCode.ToRazorPage(DummyFileName);
            string renderedText = razorPage.Render();
            return renderedText.Trim();
        }

        public static void Matches(this ISqlString sqlString, string expectedSql)
        {
            sqlString.ToSqlStringViaRazorPage().Trim().Should().Be(expectedSql);
        }
    }
}
