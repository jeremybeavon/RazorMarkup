using RazorMarkup.Database.SqlServer.Constants;
using System.ComponentModel.Composition;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class CursorFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.RegisterRaw(FunctionNames.CursorRows, () => CursorFunctions.CursorRows());
            functionRegistrationManager.RegisterRaw(FunctionNames.FetchStatus, () => CursorFunctions.FetchStatus());
            functionRegistrationManager.RegisterRaw(FunctionNames.CursorStatus, () => CursorFunctions.CursorStatus(null, null));
        }
    }
}
