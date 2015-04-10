using FluentAssertions;
using RazorMarkup.Common;
using RazorMarkup.Database.SqlServer.Parser;

namespace RazorMarkup.Database.SqlServer.Tests
{
    public static class SqlStringExtensions
    {
        public const string DummyFileName = "TestPage.cshtml";

        public static void ToSqlStringViaRazorPageIs(this ISqlString sqlString, string expectedSql)
        {
            string text = sqlString.ToSqlString();
            ISqlString sqlText = SqlSourceCodeBuilder.ToSqlString(text);
            ISourceCode sourceCode = sqlText.ToSourceCode();
            IRazorPage razorPage = sourceCode.ToRazorPage(DummyFileName);
            string renderedText = razorPage.Render();
            renderedText.Trim().Should().Be(expectedSql);
        }
    }
}
