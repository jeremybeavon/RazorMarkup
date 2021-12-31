using RazorMarkup.Database.SqlServer.Constants;
using System.ComponentModel.Composition;

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
