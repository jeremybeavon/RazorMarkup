using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Create.AvailabilityGroup;

namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateStatements
    {
        ICreateAggregateStatement Aggregate(AggregateName aggregateName);

        ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName);

        ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName);

        ICreateAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName);

        ICreateMasterKeyStatement MasterKey();
    }
}
