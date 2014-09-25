using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class DateTimeFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.RegisterRaw(FunctionNames.DateFirst, () => DateTimeFunctions.DateFirst());
            functionRegistrationManager.RegisterRaw(FunctionNames.CurrentTimestamp, () => DateTimeFunctions.CurrentTimestamp());
            functionRegistrationManager.Register(
                FunctionNames.DateAdd,
                () => DateTimeFunctions.DateAdd<SqlDate>(null, DatePart.Day, null));
            functionRegistrationManager.Register(
                new FunctionBuilder(FunctionNames.DateDiff, 1, 0, 2),
                () => DateTimeFunctions.DateDiff(null, DatePart.Day, null));
            functionRegistrationManager.Register(FunctionNames.DateFromParts, () => DateTimeFunctions.DateFromParts(null, null, null));
            functionRegistrationManager.Register(
                new FunctionBuilder(FunctionNames.DateName, 1, 0),
                () => DateTimeFunctions.DateName(null, FullDatePart.Day));
            functionRegistrationManager.Register(
                new FunctionBuilder(FunctionNames.DatePart, 1, 0),
                () => DateTimeFunctions.DatePart(null, FullDatePart.Day));
            functionRegistrationManager.Register(
                FunctionNames.DateTime2FromParts,
                () => DateTimeFunctions.DateTime2FromParts(null, null, null, null, null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DateTimeFromParts,
                () => DateTimeFunctions.DateTimeFromParts(null, null, null, null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DateTimeOffsetFromParts,
                () => DateTimeFunctions.DateTimeOffsetFromParts(null, null, null, null, null, null, null, null, null, null));
            functionRegistrationManager.Register(FunctionNames.Day, () => DateTimeFunctions.Day(null));
            functionRegistrationManager.Register(FunctionNames.EndOfMonth, () => DateTimeFunctions.EndOfMonth(null, null));
            functionRegistrationManager.Register(FunctionNames.GetDate, () => DateTimeFunctions.GetDate());
            functionRegistrationManager.Register(FunctionNames.GetUtcDate, () => DateTimeFunctions.GetUtcDate());
            functionRegistrationManager.Register(FunctionNames.IsDate, () => DateTimeFunctions.IsDate(null));
            functionRegistrationManager.Register(FunctionNames.Month, () => DateTimeFunctions.Month(null));
            functionRegistrationManager.Register(
                FunctionNames.SmallDateTimeFromParts,
                () => DateTimeFunctions.SmallDateTimeFromParts(null, null, null, null, null));
            functionRegistrationManager.Register(FunctionNames.SwitchOffset, () => DateTimeFunctions.SwitchOffset(null, null));
            functionRegistrationManager.Register(FunctionNames.SysDateTime, () => DateTimeFunctions.SysDateTime());
            functionRegistrationManager.Register(FunctionNames.SysDateTimeOffset, () => DateTimeFunctions.SysDateTimeOffset());
            functionRegistrationManager.Register(
                FunctionNames.TimeFromParts,
                () => DateTimeFunctions.TimeFromParts(null, null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.ToDateTimeOffset,
                () => DateTimeFunctions.ToDateTimeOffset(null, null));
            functionRegistrationManager.Register(FunctionNames.Year, () => DateTimeFunctions.Year(null));
        }
    }
}
