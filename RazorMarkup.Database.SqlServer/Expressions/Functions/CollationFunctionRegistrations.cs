using RazorMarkup.Database.SqlServer.Constants;
using System.ComponentModel.Composition;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class CollationFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(
                FunctionNames.CollationProperty,
                () => CollationFunctions.CollationProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.TertiaryWeights,
                () => CollationFunctions.TertiaryWeights(null));
        }
    }
}
