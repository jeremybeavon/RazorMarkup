using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class LabelStatementTests
    {
        [TestMethod]
        public void Test_Label_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Label(new LabelName("labelName")).ToSqlStringViaRazorPageIs("labelName:");
        }
    }
}
