using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class ReplicationFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(
                FunctionNames.PublishingServerName,
                () => ReplicationFunctions.PublishingServerName());
        }
    }
}
