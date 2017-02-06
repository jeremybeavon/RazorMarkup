namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupPrimaryRoleAllowConnections : IHideObjectMethods
    {
        ICreateAvailabilityGroupPrimaryRole ReadWrite();

        ICreateAvailabilityGroupPrimaryRole All();
    }
}
