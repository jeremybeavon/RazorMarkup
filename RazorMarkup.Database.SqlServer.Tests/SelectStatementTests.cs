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
        public void Test_SelectWithGroupByClauseWithGroupingSetsAndRollupColumns_GeneratesCorrectTextFromRazorPage()
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
    }
}
