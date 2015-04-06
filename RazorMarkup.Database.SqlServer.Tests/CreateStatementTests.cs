using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class CreateStatementTests
    {
        [TestMethod]
        public void Test_CreateAggregate_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE AGGREGATE aggregate
(
    @parameter1 int,
    @parameter2 money
)
RETURNS bigint
EXTERNAL NAME assembly.class";
            Sql.Create()
                .Aggregate(new AggregateName("aggregate"))
                .WithParameter(new ParameterName("@parameter1"), typeof(SqlInt))
                .And(new ParameterName("@parameter2"), new TypeName("money"))
                .Returns(new TypeName("bigint"))
                .ExternalName(new AssemblyName("assembly"), new ClassName("class"))
                .ToSqlStringViaRazorPage()
                .Should().Be(expectedResult);
        }
    }
}
