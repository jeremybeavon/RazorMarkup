using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;
using System.ComponentModel.Composition;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class StringFunctionRegistrations : IFunctionRegistrations
    {
        private const ISqlAsciiCharacterStringType Ascii = null;
        private const ISqlUnicodeCharacterStringType Unicode = null;

        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(
                FunctionNames.Ascii,
                () => StringFunctions.Ascii((SqlChar)null),
                () => StringFunctions.Ascii((SqlVarchar)null));
            functionRegistrationManager.Register(FunctionNames.Char, () => StringFunctions.Char(null));
            functionRegistrationManager.Register(
                new FunctionBuilder(FunctionNames.CharIndex, 1, 0),
                () => StringFunctions.CharIndex((ISqlNonMaxCharacterStringType)null, null),
                () => StringFunctions.CharIndex((ISqlMaxCharacterStringType)null, null));
            functionRegistrationManager.Register(
                new FunctionBuilder(FunctionNames.CharIndex, 1, 0, 2),
                () => StringFunctions.CharIndex((ISqlNonMaxCharacterStringType)null, null, null),
                () => StringFunctions.CharIndex((ISqlMaxCharacterStringType)null, null, null));
            functionRegistrationManager.Register(FunctionNames.Difference, () => StringFunctions.Difference(null, null));
            functionRegistrationManager.Register(
                FunctionNames.Format,
                () => StringFunctions.Format((ISqlNumericType)null, null),
                () => StringFunctions.Format((ISqlDateTimeType)null, null),
                () => StringFunctions.Format((ISqlNumericType)null, null, null),
                () => StringFunctions.Format((ISqlDateTimeType)null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.Left,
                () => StringFunctions.Left(Ascii, null),
                () => StringFunctions.Left(Unicode, null));
            functionRegistrationManager.Register(FunctionNames.Len, () => StringFunctions.Len(null));
            functionRegistrationManager.Register(
                FunctionNames.Lower,
                () => StringFunctions.Lower(Ascii),
                () => StringFunctions.Lower(Unicode));
            functionRegistrationManager.Register(
                FunctionNames.LeftTrim,
                () => StringFunctions.LeftTrim(Ascii),
                () => StringFunctions.LeftTrim(Unicode));
            functionRegistrationManager.Register(FunctionNames.NChar, () => StringFunctions.NChar(null));
            functionRegistrationManager.Register(
                FunctionNames.PatternIndex,
                () => StringFunctions.PatternIndex((ISqlNonMaxCharacterStringType)null, null),
                () => StringFunctions.PatternIndex((ISqlMaxCharacterStringType)null, null));
            functionRegistrationManager.Register(
                FunctionNames.QuoteName,
                () => StringFunctions.QuoteName(null),
                () => StringFunctions.QuoteName(null, null));
            functionRegistrationManager.Register(
                FunctionNames.Replace,
                () => StringFunctions.Replace(Ascii, Ascii, Ascii),
                () => StringFunctions.Replace(Ascii, Unicode, Ascii),
                () => StringFunctions.Replace(Ascii, Ascii, Unicode),
                () => StringFunctions.Replace(Ascii, Unicode, Unicode),
                () => StringFunctions.Replace(Unicode, null, null));
            functionRegistrationManager.Register(
                FunctionNames.Replicate,
                () => StringFunctions.Replicate((SqlChar)null, null),
                () => StringFunctions.Replicate((SqlNChar)null, null),
                () => StringFunctions.Replicate((SqlVarchar)null, null),
                () => StringFunctions.Replicate((SqlNVarchar)null, null),
                () => StringFunctions.Replicate((SqlVarcharMax)null, null),
                () => StringFunctions.Replicate((SqlNVarcharMax)null, null));
            functionRegistrationManager.Register(
                FunctionNames.Reverse,
                () => StringFunctions.Reverse(Ascii),
                () => StringFunctions.Reverse(Unicode));
            functionRegistrationManager.Register(
                FunctionNames.Right,
                () => StringFunctions.Right(Ascii, null),
                () => StringFunctions.Right(Unicode, null));
            functionRegistrationManager.Register(
                FunctionNames.RightTrim,
                () => StringFunctions.RightTrim(Ascii),
                () => StringFunctions.RightTrim(Unicode));
            functionRegistrationManager.Register(FunctionNames.Soundex, () => StringFunctions.Soundex(null));
            functionRegistrationManager.Register(FunctionNames.Space, () => StringFunctions.Space(null));
            functionRegistrationManager.Register(FunctionNames.Str, () => StringFunctions.Str(null, null, null));
            functionRegistrationManager.Register(FunctionNames.Stuff, () => StringFunctions.Stuff<SqlChar>(null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.Substring,
                () => StringFunctions.Substring(Ascii, null, null),
                () => StringFunctions.Substring((SqlText)null, null, null),
                () => StringFunctions.Substring(Unicode, null, null),
                () => StringFunctions.Substring((SqlNText)null, null, null),
                () => StringFunctions.Substring((ISqlBinaryType)null, null, null));
            functionRegistrationManager.Register(FunctionNames.Unicode, () => StringFunctions.Unicode(null));
            functionRegistrationManager.Register(
                FunctionNames.Upper,
                () => StringFunctions.Upper(Ascii),
                () => StringFunctions.Upper(Unicode));
        }
    }
}
