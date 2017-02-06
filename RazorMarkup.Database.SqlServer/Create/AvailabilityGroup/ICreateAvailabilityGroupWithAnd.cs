namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupWithAnd : IHideObjectMethods
    {
        ICreateAvailabilityGroupWith And();

        ICreateAvailabilityGroupFor For();
    }
}
