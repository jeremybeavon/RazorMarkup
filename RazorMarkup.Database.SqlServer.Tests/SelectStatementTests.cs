using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class SelectStatementTests
    {
        [TestMethod]
        public void Test_SelectAll_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT ALL *
FROM table1";
            Sql.Query().Select().All().AllColumns().From().Table(new TableName("table1")).End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithDistinct_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT DISTINCT *
FROM table1";
            Sql.Query().Select().Distinct().AllColumns().From().Table(new TableName("table1")).End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTop_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT TOP 10 *
FROM table1";
            Sql.Query().Select().Top(() => 10).AllColumns().From().Table(new TableName("table1")).End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTopPercent_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT TOP 12 PERCENT *
FROM table1";
            Sql.Query().Select().Top(() => 12).Percent().AllColumns().From().Table(new TableName("table1")).End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectTopWithTies_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT TOP 12 WITH TIES *
FROM table1";
            Sql.Query().Select().Top(() => 12).WithTies().AllColumns().From().Table(new TableName("table1")).End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithAllColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1";
            Sql.Query().Select().AllColumns().From().Table(new TableName("table1")).End().Query().ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithInto_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
INTO tempTable
FROM table1";
            Sql.Query().Select().AllColumns()
                .Into(new TableName("tempTable"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithInnerJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedInnerJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER JOIN table2
INNER JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerJoin().Table(new TableName("table2"))
                .InnerJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithLeftJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedLeftJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT JOIN table2
LEFT JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftJoin().Table(new TableName("table2"))
                .LeftJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithRightJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedRightJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT JOIN table2
RIGHT JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightJoin().Table(new TableName("table2"))
                .RightJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithFullJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedFullJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL JOIN table2
FULL JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullJoin().Table(new TableName("table2"))
                .FullJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }
    }
}
