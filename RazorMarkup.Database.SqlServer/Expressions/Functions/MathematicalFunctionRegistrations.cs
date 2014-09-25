using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class MathematicalFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(FunctionNames.Abs, () => MathematicalFunctions.Abs<SqlInt>(null));
            functionRegistrationManager.Register(FunctionNames.Acos, () => MathematicalFunctions.Acos(null));
            functionRegistrationManager.Register(FunctionNames.Asin, () => MathematicalFunctions.Asin(null));
            functionRegistrationManager.Register(FunctionNames.Atan, () => MathematicalFunctions.Atan(null));
            functionRegistrationManager.Register(FunctionNames.Atn2, () => MathematicalFunctions.Atn2(null, null));
            functionRegistrationManager.Register(FunctionNames.Ceiling, () => MathematicalFunctions.Ceiling<SqlFloat>(null));
            functionRegistrationManager.Register(FunctionNames.Cos, () => MathematicalFunctions.Cos(null));
            functionRegistrationManager.Register(FunctionNames.Cot, () => MathematicalFunctions.Cot(null));
            functionRegistrationManager.Register(FunctionNames.Degrees, () => MathematicalFunctions.Degrees<SqlInt>(null));
            functionRegistrationManager.Register(FunctionNames.Exp, () => MathematicalFunctions.Exp(null));
            functionRegistrationManager.Register(FunctionNames.Floor, () => MathematicalFunctions.Floor<SqlFloat>(null));
            functionRegistrationManager.Register(
                FunctionNames.Log,
                () => MathematicalFunctions.Log(null),
                () => MathematicalFunctions.Log(null, null));
            functionRegistrationManager.Register(FunctionNames.Log10, () => MathematicalFunctions.Log10(null));
            functionRegistrationManager.Register(FunctionNames.Pi, () => MathematicalFunctions.Pi());
            functionRegistrationManager.Register(FunctionNames.Power, () => MathematicalFunctions.Power<SqlFloat>(null, null));
            functionRegistrationManager.Register(FunctionNames.Radians, () => MathematicalFunctions.Radians<SqlInt>(null));
            functionRegistrationManager.Register(
                FunctionNames.Rand,
                () => MathematicalFunctions.Rand(),
                () => MathematicalFunctions.Rand(null));
            functionRegistrationManager.Register(
                FunctionNames.Round,
                () => MathematicalFunctions.Round((SqlTinyInt)null, null),
                () => MathematicalFunctions.Round((SqlSmallInt)null, null),
                () => MathematicalFunctions.Round((SqlInt)null, null),
                () => MathematicalFunctions.Round((SqlBigInt)null, null),
                () => MathematicalFunctions.Round((SqlDecimal)null, null),
                () => MathematicalFunctions.Round((SqlNumeric)null, null),
                () => MathematicalFunctions.Round((SqlMoney)null, null),
                () => MathematicalFunctions.Round((SqlSmallMoney)null, null),
                () => MathematicalFunctions.Round((SqlFloat)null, null),
                () => MathematicalFunctions.Round((SqlReal)null, null),
                () => MathematicalFunctions.Round((SqlTinyInt)null, null, null),
                () => MathematicalFunctions.Round((SqlSmallInt)null, null, null),
                () => MathematicalFunctions.Round((SqlInt)null, null, null),
                () => MathematicalFunctions.Round((SqlBigInt)null, null, null),
                () => MathematicalFunctions.Round((SqlDecimal)null, null, null),
                () => MathematicalFunctions.Round((SqlNumeric)null, null, null),
                () => MathematicalFunctions.Round((SqlMoney)null, null, null),
                () => MathematicalFunctions.Round((SqlSmallMoney)null, null, null),
                () => MathematicalFunctions.Round((SqlFloat)null, null, null),
                () => MathematicalFunctions.Round((SqlReal)null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.Sign,
                () => MathematicalFunctions.Sign((SqlBigInt)null),
                () => MathematicalFunctions.Sign((SqlInt)null),
                () => MathematicalFunctions.Sign((SqlSmallInt)null),
                () => MathematicalFunctions.Sign((SqlTinyInt)null),
                () => MathematicalFunctions.Sign((SqlMoney)null),
                () => MathematicalFunctions.Sign((SqlSmallMoney)null),
                () => MathematicalFunctions.Sign((SqlNumeric)null),
                () => MathematicalFunctions.Sign((SqlDecimal)null),
                () => MathematicalFunctions.Sign((SqlFloat)null),
                () => MathematicalFunctions.Sign((SqlReal)null));
            functionRegistrationManager.Register(FunctionNames.Sin, () => MathematicalFunctions.Sin(null));
            functionRegistrationManager.Register(FunctionNames.Sqrt, () => MathematicalFunctions.Sqrt(null));
            functionRegistrationManager.Register(FunctionNames.Square, () => MathematicalFunctions.Square(null));
            functionRegistrationManager.Register(FunctionNames.Tan, () => MathematicalFunctions.Tan(null));
        }
    }
}
