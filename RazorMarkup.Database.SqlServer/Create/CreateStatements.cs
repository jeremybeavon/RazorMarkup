using System;
using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;

namespace RazorMarkup.Database.SqlServer.Create
{
    internal sealed class CreateStatements : ICreateStatements
    {
        public ICreateAggregateStatement Aggregate(AggregateName aggregateName)
        {
            return new CreateAggregateStatement(aggregateName);
        }

        public ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName)
        {
            throw new NotImplementedException();
        }

        public ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName)
        {
            return new CreateAssemblyStatementWithAuthorization(assemblyName);
        }
    }
}
