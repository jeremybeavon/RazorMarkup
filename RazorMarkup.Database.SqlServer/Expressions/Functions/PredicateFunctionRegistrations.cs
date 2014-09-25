using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class PredicateFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.RegisterRaw(FunctionNames.IsNull, () => Predicates.IsNull<SqlInt>(null));
            functionRegistrationManager.RegisterRaw(FunctionNames.IsNotNull, () => Predicates.IsNotNull<SqlInt>(null));
        }
    }
}
