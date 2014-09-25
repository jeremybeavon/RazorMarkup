namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface IFunctionRegistrations
    {
        void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager);
    }
}
