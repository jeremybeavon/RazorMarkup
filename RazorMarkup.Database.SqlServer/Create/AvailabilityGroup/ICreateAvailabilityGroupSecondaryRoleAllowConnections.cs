namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupSecondaryRoleAllowConnections : IHideObjectMethods
    {
        ICreateAvailabilityGroupSecondaryRole No();

        ICreateAvailabilityGroupSecondaryRole ReadOnly();

        ICreateAvailabilityGroupSecondaryRole All();
    }
}
