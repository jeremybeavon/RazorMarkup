using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class TriggerFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(FunctionNames.ColumnsUpdated, () => TriggerFunctions.ColumnsUpdated());
            functionRegistrationManager.Register(FunctionNames.EventData, () => TriggerFunctions.EventData());
            functionRegistrationManager.Register(
                FunctionNames.TriggerNestLevel,
                () => TriggerFunctions.TriggerNestLevel(null, null, null));
            functionRegistrationManager.Register(FunctionNames.Update, () => TriggerFunctions.Update(null));
        }
    }
}
