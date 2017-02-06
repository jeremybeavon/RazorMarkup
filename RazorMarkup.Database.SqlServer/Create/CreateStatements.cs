using System;
using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Create.AvailabilityGroup;

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

        public ICreateAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName)
        {
            return new CreateAvailabilityGroupStatement(availabilityGroupName);
        }

        public ICreateMasterKeyStatement MasterKey()
        {
            return new CreateMasterKeyStatement();
        }
    }
}
