using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class SystemFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(
                "$PARTITION",
                //() => new PartitionFunctionBuilder(),
                () => SystemFunctions.Partition(null, null),
                () => SystemFunctions.Partition(null, null, null));
            functionRegistrationManager.RegisterRaw(FunctionNames.Error, () => SystemFunctions.Error());
            functionRegistrationManager.RegisterRaw(FunctionNames.IdentityVariable, () => SystemFunctions.Identity());
            functionRegistrationManager.RegisterRaw(FunctionNames.PackReceived, () => SystemFunctions.PackReceived());
            functionRegistrationManager.RegisterRaw(FunctionNames.RowCount, () => SystemFunctions.RowCount());
            functionRegistrationManager.RegisterRaw(FunctionNames.TransactionCount, () => SystemFunctions.TransactionCount());
            functionRegistrationManager.Register(
                FunctionNames.BinaryChecksum,
                () => SystemFunctions.BinaryChecksum(),
                () => SystemFunctions.BinaryChecksum(null));
            functionRegistrationManager.Register(
                FunctionNames.Checksum,
                () => SystemFunctions.Checksum(),
                () => SystemFunctions.Checksum(null));
            functionRegistrationManager.Register(
                FunctionNames.ConnectionProperty,
                () => SystemFunctions.ConnectionProperty(null));
            functionRegistrationManager.Register(FunctionNames.ContextInfo, () => SystemFunctions.ContextInfo());
            functionRegistrationManager.Register(FunctionNames.CurrentRequestId, () => SystemFunctions.CurrentRequestId());
            functionRegistrationManager.Register(FunctionNames.ErrorLine, () => SystemFunctions.ErrorLine());
            functionRegistrationManager.Register(FunctionNames.ErrorMessage, () => SystemFunctions.ErrorMessage());
            functionRegistrationManager.Register(FunctionNames.ErrorNumber, () => SystemFunctions.ErrorNumber());
            functionRegistrationManager.Register(FunctionNames.ErrorProcedure, () => SystemFunctions.ErrorProcedure());
            functionRegistrationManager.Register(FunctionNames.ErrorSeverity, () => SystemFunctions.ErrorSeverity());
            functionRegistrationManager.Register(FunctionNames.ErrorState, () => SystemFunctions.ErrorState());
            functionRegistrationManager.Register(FunctionNames.FormatMessage, () => SystemFunctions.FormatMessage(null));
            functionRegistrationManager.Register(
                FunctionNames.GetAnsiNull,
                () => SystemFunctions.GetAnsiNull(),
                () => SystemFunctions.GetAnsiNull((DatabaseName)null),
                () => SystemFunctions.GetAnsiNull((SqlNChar)null));
            functionRegistrationManager.Register(
                FunctionNames.GetFileStreamTransactionContext,
                () => SystemFunctions.GetFileStreamTransactionContext());
            functionRegistrationManager.Register(FunctionNames.HostId, () => SystemFunctions.HostId());
            functionRegistrationManager.Register(FunctionNames.HostName, () => SystemFunctions.HostName());
            functionRegistrationManager.Register(
                FunctionNames.IsNullFunction,
                () => SystemFunctions.IsNull<SqlInt>(null, null));
            functionRegistrationManager.Register(FunctionNames.IsNumeric, () => SystemFunctions.IsNumeric(null));
            functionRegistrationManager.Register(
                FunctionNames.MinActiveRowVersion,
                () => SystemFunctions.MinActiveRowVersion());
            functionRegistrationManager.Register(FunctionNames.NewId, () => SystemFunctions.NewId());
            functionRegistrationManager.Register(FunctionNames.NewSequentialId, () => SystemFunctions.NewSequentialId());
            functionRegistrationManager.Register(FunctionNames.RowCountBig, () => SystemFunctions.RowCountBig());
            functionRegistrationManager.Register(FunctionNames.TransactionState, () => SystemFunctions.TransactionState());
        }
    }
}
