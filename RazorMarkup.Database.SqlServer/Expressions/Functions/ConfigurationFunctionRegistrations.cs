using RazorMarkup.Database.SqlServer.Constants;
using System.ComponentModel.Composition;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class ConfigurationFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.RegisterRaw(FunctionNames.DatabaseTimestamp, () => ConfigurationFunctions.DatabaseTimestamp());
            functionRegistrationManager.RegisterRaw(FunctionNames.LanguageId, () => ConfigurationFunctions.LanguageId());
            functionRegistrationManager.RegisterRaw(FunctionNames.Language, () => ConfigurationFunctions.Language());
            functionRegistrationManager.RegisterRaw(FunctionNames.LockTimeout, () => ConfigurationFunctions.LockTimeout());
            functionRegistrationManager.RegisterRaw(FunctionNames.MaxConnections, () => ConfigurationFunctions.MaxConnections());
            functionRegistrationManager.RegisterRaw(FunctionNames.MaxPrecision, () => ConfigurationFunctions.MaxPrecision());
            functionRegistrationManager.RegisterRaw(FunctionNames.NestLevel, () => ConfigurationFunctions.NestLevel());
            functionRegistrationManager.RegisterRaw(FunctionNames.Options, () => ConfigurationFunctions.Options());
            functionRegistrationManager.RegisterRaw(FunctionNames.ServerName, () => ConfigurationFunctions.ServerName());
            functionRegistrationManager.RegisterRaw(FunctionNames.ServiceName, () => ConfigurationFunctions.ServiceName());
            functionRegistrationManager.RegisterRaw(FunctionNames.SessionId, () => ConfigurationFunctions.SessionId());
            functionRegistrationManager.RegisterRaw(FunctionNames.TextSize, () => ConfigurationFunctions.TextSize());
            functionRegistrationManager.RegisterRaw(FunctionNames.SqlVersion, () => ConfigurationFunctions.Version());
        }
    }
}
