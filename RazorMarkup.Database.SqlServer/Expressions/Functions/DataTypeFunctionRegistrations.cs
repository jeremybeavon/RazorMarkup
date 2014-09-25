using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class DataTypeFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(FunctionNames.DataLength, () => DataTypeFunctions.DataLength(null));
            functionRegistrationManager.Register(FunctionNames.IdentityCurrent, () => DataTypeFunctions.IdentityCurrent(null));
            functionRegistrationManager.Register(
                FunctionNames.IdentityIncrement,
                () => DataTypeFunctions.IdentityIncrement(null));
            functionRegistrationManager.Register(FunctionNames.IdentitySeed, () => DataTypeFunctions.IdentitySeed(null));
            functionRegistrationManager.Register(
                FunctionNames.Identity,
                () => DataTypeFunctions.Identity<SqlInt>(null),
                () => DataTypeFunctions.Identity<SqlInt>(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.SqlVariantProperty,
                () => DataTypeFunctions.SqlVariantProperty(null, null));
        }
    }
}
