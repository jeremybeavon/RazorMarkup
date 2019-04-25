using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorMarkup.Database.SqlServer.Types;

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
        public void Test_SelectWithAllTableColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT table1.*
FROM table1";
            Sql.Query().Select().AllColumns(new TableName("table1")).From().Table(new TableName("table1")).End().Query().ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithAllViewColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT view1.*
FROM table1";
            Sql.Query().Select().AllColumns(new ViewName("view1")).From().Table(new TableName("table1")).End().Query().ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithAllTableAliasColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT table1.*
FROM table2 AS table1";
            Sql.Query()
                .Select().AllColumns(new TableAlias("table1"))
                .From().Table(new TableName("table2")).As(new TableAlias("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithIdentityColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT $IDENTITY
FROM table1";
            Sql.Query()
                .Select().IdentityColumn()
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTableIdentityColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT table1.$IDENTITY
FROM table1";
            Sql.Query()
                .Select().IdentityColumn(new TableName("table1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithViewIdentityColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT view1.$IDENTITY
FROM view1";
            Sql.Query()
                .Select().IdentityColumn(new ViewName("view1"))
                .From().View(new ViewName("view1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTableAliasIdentityColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT alias1.$IDENTITY
FROM table1 AS alias1";
            Sql.Query()
                .Select().IdentityColumn(new TableAlias("alias1"))
                .From().Table(new TableName("table1")).As(new TableAlias("alias1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithRowGuidColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT $ROWGUID
FROM table1";
            Sql.Query()
                .Select().RowGuidColumn()
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTableRowGuidColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT table1.$ROWGUID
FROM table1";
            Sql.Query()
                .Select().RowGuidColumn(new TableName("table1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithViewRowGuidColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT view1.$ROWGUID
FROM view1";
            Sql.Query()
                .Select().RowGuidColumn(new ViewName("view1"))
                .From().View(new ViewName("view1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithTableAliasRowGuidColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT alias1.$ROWGUID
FROM table1 AS alias1";
            Sql.Query()
                .Select().RowGuidColumn(new TableAlias("alias1"))
                .From().Table(new TableName("table1")).As(new TableAlias("alias1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrTableColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT table1.column1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new TableName("table1"), new ClrColumnName("column1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrViewColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT view1.column1
FROM view1";
            Sql.Query()
                .Select().ClrColumn(new ViewName("view1"), new ClrColumnName("column1"))
                .From().View(new ViewName("view1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrTableAliasColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT alias1.column1
FROM table1 AS alias1";
            Sql.Query()
                .Select().ClrColumn(new TableAlias("alias1"), new ClrColumnName("column1"))
                .From().Table(new TableName("table1")).As(new TableAlias("alias1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrFieldColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1.field1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).Field(new ClrFieldName("field1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrPropertyColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1.property1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).Property(new ClrPropertyName("property1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrStaticFieldColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1::field1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).StaticField(new ClrFieldName("field1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrStaticPropertyColumn_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1::property1
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).StaticProperty(new ClrPropertyName("property1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrMethodColumnWithNoParameters_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1.method1()
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).Method(new ClrMethodName("method1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrMethodColumnWithOneParameter_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1.method1('test')
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).Method(new ClrMethodName("method1"), () => "test")
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrMethodColumnWithTwoParameters_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1.method1('test', 2)
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).Method(new ClrMethodName("method1"), () => "test", () => 2)
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrStaticMethodColumnWithNoParameters_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1::method1()
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).StaticMethod(new ClrMethodName("method1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrStaticMethodColumnWithOneParameter_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1::method1('test')
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).StaticMethod(new ClrMethodName("method1"), () => "test")
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithClrStaticMethodColumnWithTwoParameters_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1::method1('test', 2)
FROM table1";
            Sql.Query()
                .Select().ClrColumn(new ClrColumnName("column1")).StaticMethod(new ClrMethodName("method1"), () => "test", () => 2)
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectColumnWithAlias_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1 AS alias1
FROM table1";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).As(new ColumnAlias("alias1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        /*[TestMethod]
        public void Test_SelectColumnWithAliasUsingEquals_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT alias1 = column1
FROM table1";
            Sql.Query()
                .Select().Column(new ColumnAlias("alias1"), () => new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }*/

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
        public void Test_SelectWithInnerLoopJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER LOOP JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerLoopJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithInnerHashJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER HASH JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerHashJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithInnerMergeJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER MERGE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerMergeJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithInnerRemoteJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER REMOTE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerRemoteJoin().Table(new TableName("table2"))
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
        public void Test_SelectWithNestedLoopInnerJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER LOOP JOIN table2
INNER LOOP JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerLoopJoin().Table(new TableName("table2"))
                .InnerLoopJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedHashInnerJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER HASH JOIN table2
INNER HASH JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerHashJoin().Table(new TableName("table2"))
                .InnerHashJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedMergeInnerJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER MERGE JOIN table2
INNER MERGE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerMergeJoin().Table(new TableName("table2"))
                .InnerMergeJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedRemoteInnerJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
INNER REMOTE JOIN table2
INNER REMOTE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .InnerRemoteJoin().Table(new TableName("table2"))
                .InnerRemoteJoin().Table(new TableName("table3"))
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
        public void Test_SelectWithLeftLoopJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT LOOP JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftLoopJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithLeftHashJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT HASH JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftHashJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithLeftMergeJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT MERGE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftMergeJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithLeftRemoteJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT REMOTE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftRemoteJoin().Table(new TableName("table2"))
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
        public void Test_SelectWithNestedLoopLeftJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT LOOP JOIN table2
LEFT LOOP JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftLoopJoin().Table(new TableName("table2"))
                .LeftLoopJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedHashLeftJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT HASH JOIN table2
LEFT HASH JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftHashJoin().Table(new TableName("table2"))
                .LeftHashJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedMergeLeftJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT MERGE JOIN table2
LEFT MERGE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftMergeJoin().Table(new TableName("table2"))
                .LeftMergeJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedRemoteLeftJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
LEFT REMOTE JOIN table2
LEFT REMOTE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .LeftRemoteJoin().Table(new TableName("table2"))
                .LeftRemoteJoin().Table(new TableName("table3"))
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
        public void Test_SelectWithRightLoopJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT LOOP JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightLoopJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithRightHashJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT HASH JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightHashJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithRightMergeJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT MERGE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightMergeJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithRightRemoteJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT REMOTE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightRemoteJoin().Table(new TableName("table2"))
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
        public void Test_SelectWithNestedLoopRightJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT LOOP JOIN table2
RIGHT LOOP JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightLoopJoin().Table(new TableName("table2"))
                .RightLoopJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedHashRightJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT HASH JOIN table2
RIGHT HASH JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightHashJoin().Table(new TableName("table2"))
                .RightHashJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedMergeRightJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT MERGE JOIN table2
RIGHT MERGE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightMergeJoin().Table(new TableName("table2"))
                .RightMergeJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedRemoteRightJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
RIGHT REMOTE JOIN table2
RIGHT REMOTE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .RightRemoteJoin().Table(new TableName("table2"))
                .RightRemoteJoin().Table(new TableName("table3"))
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
        public void Test_SelectWithFullLoopJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL LOOP JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullLoopJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithFullHashJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL HASH JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullHashJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithFullMergeJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL MERGE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullMergeJoin().Table(new TableName("table2"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithFullRemoteJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL REMOTE JOIN table2
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullRemoteJoin().Table(new TableName("table2"))
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

        [TestMethod]
        public void Test_SelectWithNestedLoopFullJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL LOOP JOIN table2
FULL LOOP JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullLoopJoin().Table(new TableName("table2"))
                .FullLoopJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedHashFullJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL HASH JOIN table2
FULL HASH JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullHashJoin().Table(new TableName("table2"))
                .FullHashJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedMergeFullJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL MERGE JOIN table2
FULL MERGE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullMergeJoin().Table(new TableName("table2"))
                .FullMergeJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithNestedRemoteFullJoins_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
FULL REMOTE JOIN table2
FULL REMOTE JOIN table3
ON table2.column1 = table3.column1
ON table1.column1 = table2.column1";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .FullRemoteJoin().Table(new TableName("table2"))
                .FullRemoteJoin().Table(new TableName("table3"))
                .On(() => new ColumnName("table2.column1") == new ColumnName("table3.column1"))
                .On(() => new ColumnName("table1.column1") == new ColumnName("table2.column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithCrossJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1 CROSS JOIN table2";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .CrossJoin().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithCrossApplyJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1 CROSS APPLY table2";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .CrossApplyJoin().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOuterApplyJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1 OUTER APPLY table2";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .OuterApplyJoin().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWith2Tables_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1, table2";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .And().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        /*[TestMethod]
        public void Test_SelectWithPivotJoin_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
PIVOT (COUNT(column1) FOR column2 IN (test1, test2, test3)) AS testPivot";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .Pivot()
        }*/

        [TestMethod]
        public void Test_SelectWithSubquery_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM
(
    SELECT *
    FROM table1
) AS table2";
            Sql.Query()
                .Select().AllColumns()
                .From().Subquery().Select().AllColumns().From().Table(new TableName("table1")).End().Subquery().As(new TableAlias("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithWhereClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT *
FROM table1
WHERE column1 = 'test'";
            Sql.Query()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") == "test")
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
UNION
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Union()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionAllClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
UNION ALL
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .UnionAll()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithExceptClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
EXCEPT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithIntersectClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
INTERSECT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Intersect()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionAndWhereClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 < 10
UNION
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") < 10)
                .Union()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionAllAndWhereClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 < 10
UNION ALL
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") < 10)
                .UnionAll()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithExceptAndWhereClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 < 10
EXCEPT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") < 10)
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithIntersectAndWhereClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 < 10
INTERSECT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") < 10)
                .Intersect()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithWhereAndGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 < 10
GROUP BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") < 10)
                .GroupBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith2Columns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY column1,
    column2";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1")).And(() => new ColumnName("column2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithWhereAndGroupByClauseWithRollup_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 > 10
GROUP BY ROLLUP
(
    column1
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") > 10)
                .GroupBy().Rollup(() => new ColumnName("column1")).EndRollup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithRollup_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY ROLLUP
(
    column1
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy().Rollup(() => new ColumnName("column1")).EndRollup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith2RollupColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY ROLLUP
(
    column1,
    column2
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy().Rollup(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndRollup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith3RollupColumnsAnd1Group_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY ROLLUP
(
    (
        column1,
        column2
    ),
    column3
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().Rollup().Group(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndGroup().And(() => new ColumnName("column3")).EndRollup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith3RollupColumnsAnd2Groups_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY ROLLUP
(
    (
        column1,
        column2
    ),
    (
        column1,
        column3
    )
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().Rollup()
                .Group(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndGroup().And()
                .Group(() => new ColumnName("column1")).And(() => new ColumnName("column3")).EndGroup()
                .EndRollup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithCube_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY CUBE
(
    column1
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy().Cube(() => new ColumnName("column1")).EndCube()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith2CubeColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY CUBE
(
    column1,
    column2
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy().Cube(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndCube()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith3CubeColumnsAnd1Group_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY CUBE
(
    (
        column1,
        column2
    ),
    column3
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().Cube().Group(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndGroup().And(() => new ColumnName("column3")).EndCube()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith3CubeColumnsAnd2Groups_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY CUBE
(
    (
        column1,
        column2
    ),
    (
        column1,
        column3
    )
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().Cube()
                .Group(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndGroup().And()
                .Group(() => new ColumnName("column1")).And(() => new ColumnName("column3")).EndGroup()
                .EndCube()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithGroupingSets_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY GROUPING SETS
(
    column1
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy().GroupingSets(() => new ColumnName("column1")).EndGroupingSets()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWith2GroupingSetsColumns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY GROUPING SETS
(
    column1,
    column2
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy().GroupingSets(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndGroupingSets()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithGroupingSetsAndRollup_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY GROUPING SETS
(
    ROLLUP
    (
        column1,
        column2
    ),
    column3
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().GroupingSets()
                .Rollup(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndRollup()
                .And(() => new ColumnName("column3"))
                .EndGroupingSets()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithGroupingSetsAndCube_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2,
    column3
FROM table1
GROUP BY GROUPING SETS
(
    CUBE
    (
        column1,
        column2
    ),
    column3
)";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2")).And().Column(new ColumnName("column3"))
                .From().Table(new TableName("table1"))
                .GroupBy().GroupingSets()
                .Cube(() => new ColumnName("column1")).And(() => new ColumnName("column2")).EndCube()
                .And(() => new ColumnName("column3"))
                .EndGroupingSets()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithGrandTotal_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY ()";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy().GrandTotal()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByClauseWithRollupAndGrandTotal_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
GROUP BY ROLLUP
(
    column1
),
    ()";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .GroupBy().Rollup(() => new ColumnName("column1")).EndRollup().And().GrandTotal()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionAndGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
UNION
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Union()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithUnionAllAndGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
UNION ALL
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .UnionAll()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithExceptAndGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
EXCEPT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithIntersectAndGroupByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
INTERSECT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Intersect()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 < 10";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") < 10)
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndUnionClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 < 10
UNION
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") < 10)
                .Union()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndUnionAllClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 < 10
UNION ALL
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") < 10)
                .UnionAll()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndIntersectClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 < 10
INTERSECT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") < 10)
                .Intersect()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndExceptClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 < 10
EXCEPT
SELECT column2
FROM table2";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") < 10)
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWith2UnionClauses_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"(
    SELECT column1
    FROM table1
    UNION
    SELECT column2
    FROM table2
)
UNION
SELECT column3
FROM table3";
            Sql.Query()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Union()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().OperatorGroup()
                .Union()
                .Select().Column(new ColumnName("column3"))
                .From().Table(new TableName("table3"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWith2UnionAllClauses_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"(
    SELECT column1
    FROM table1
    UNION ALL
    SELECT column2
    FROM table2
)
UNION ALL
SELECT column3
FROM table3";
            Sql.Query()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .UnionAll()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().OperatorGroup()
                .UnionAll()
                .Select().Column(new ColumnName("column3"))
                .From().Table(new TableName("table3"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWith2IntersectClauses_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"(
    SELECT column1
    FROM table1
    INTERSECT
    SELECT column2
    FROM table2
)
INTERSECT
SELECT column3
FROM table3";
            Sql.Query()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Intersect()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().OperatorGroup()
                .Intersect()
                .Select().Column(new ColumnName("column3"))
                .From().Table(new TableName("table3"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWith2ExceptClauses_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"(
    SELECT column1
    FROM table1
    EXCEPT
    SELECT column2
    FROM table2
)
EXCEPT
SELECT column3
FROM table3";
            Sql.Query()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().OperatorGroup()
                .Except()
                .Select().Column(new ColumnName("column3"))
                .From().Table(new TableName("table3"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByClauseAndCollate_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1 COLLATE Latin1_General_CS_AS";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1")).Collate(new CollationName("Latin1_General_CS_AS"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByClauseAndAscending_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1 ASC";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1")).Ascending()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByClauseAndDescending_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1 DESC";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1")).Descending()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByClauseAnd2Columns_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1,
    column2
FROM table1
ORDER BY column1,
    column2";
            Sql.Query()
                .Select().Column(new ColumnName("column1")).And().Column(new ColumnName("column2"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1")).And(() => new ColumnName("column2"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithWhereAndOrderByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 > 10
ORDER BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") > 10)
                .OrderBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByAndOrderByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
ORDER BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .OrderBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndOrderByClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 > 1
ORDER BY column1";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") > 1)
                .OrderBy(() => new ColumnName("column1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOffsetClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
OFFSET 10 ROWS";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .Offset(() => 10).Rows()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOffsetClauseAndSingleOffset_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
OFFSET 1 ROW";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .Offset(() => 1).Row()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOffsetAndFetchClausesWithFirst_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
OFFSET 10 ROWS
FETCH FIRST 20 ROWS ONLY";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .Offset(() => 10).Rows()
                .FetchFirst(() => 20).Rows().Only()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOffsetAndFetchClausesWithNext_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
OFFSET 10 ROWS
FETCH NEXT 1 ROW ONLY";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .Offset(() => 10).Rows()
                .FetchNext(() => 1).Row().Only()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithWhereAndForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
WHERE column1 > 10
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Where(() => new ColumnName("column1") > 10)
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithGroupByAndForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithHavingAndForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
GROUP BY column1
HAVING column1 > 1
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .GroupBy(() => new ColumnName("column1"))
                .Having(() => new ColumnName("column1") > 1)
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOrderByAndForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOffsetAndForBrowseClause_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
ORDER BY column1
OFFSET 10 ROWS
FOR BROWSE";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .OrderBy(() => new ColumnName("column1"))
                .Offset(() => 10).Rows()
                .For().Browse()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        /*[TestMethod]
        public void Test_SelectWithForXmlAuto_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"SELECT column1
FROM table1
FOR XML AUTO";
            Sql.Query()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .For().Xml().Auto()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }*/

        [TestMethod]
        public void Test_SelectWithOperatorGroups_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"(
    SELECT column1
    FROM table1
    EXCEPT
    SELECT column2
    FROM table2
)
UNION ALL
(
    SELECT column3
    FROM table3
    INTERSECT
    SELECT column4
    FROM table4
)";
            Sql.Query()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column1"))
                .From().Table(new TableName("table1"))
                .Except()
                .Select().Column(new ColumnName("column2"))
                .From().Table(new TableName("table2"))
                .End().OperatorGroup()
                .UnionAll()
                .BeginQueryGroup()
                .Select().Column(new ColumnName("column3"))
                .From().Table(new TableName("table3"))
                .Intersect()
                .Select().Column(new ColumnName("column4"))
                .From().Table(new TableName("table4"))
                .End().OperatorGroup()
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_SelectWithOneCTE_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql = @"WITH CTE1(column1) AS (
    SELECT *
    FROM table1
)
SELECT *
FROM CTE1";
            Sql.Query()
                .With(new TableAlias("CTE1"), new ColumnAlias("column1")).As()
                .Select().AllColumns()
                .From().Table(new TableName("table1"))
                .End().With()
                .Select().AllColumns()
                .From().Table(new TableName("CTE1"))
                .End().Query()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }
    }
}
