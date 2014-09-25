using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class StringFunctions
    {
        public static SqlInt Ascii(this SqlChar character)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Ascii(this SqlVarchar character)
        {
            throw new NotInExpressionException();
        }

        public static SqlChar Char(this ISqlIntegerType integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt CharIndex(this ISqlNonMaxCharacterStringType expressionToSearch, Text expressionToFind)
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt CharIndex(this ISqlMaxCharacterStringType expressionToSearch, Text expressionToFind)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt CharIndex(
            this ISqlNonMaxCharacterStringType expressionToSearch,
            Text expressionToFind,
            SqlBigInt startLocation)
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt CharIndex(
            this ISqlMaxCharacterStringType expressionToSearch,
            Text expressionToFind,
            SqlBigInt startLocation)
        {
            throw new NotInExpressionException();
        }

        /*public static ISqlCharacterStringType Concat(
            this ISqlCharacterStringType value1,
            params ISqlCharacterStringType[] values)
        {
            throw new NotInExpressionException();
        }*/

        public static SqlInt Difference(this ISqlCharacterStringType value1, Text value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Format(this ISqlNumericType value, NVarchar format)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Format(this ISqlDateTimeType value, NVarchar format)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Format(this ISqlNumericType value, NVarchar format, NVarchar culture)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Format(this ISqlDateTimeType value, NVarchar format, NVarchar culture)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Left(this ISqlAsciiCharacterStringType value, Integer integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Left(this ISqlUnicodeCharacterStringType value, Integer integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Len(this ISqlCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Lower(this ISqlAsciiCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Lower(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar LeftTrim(this ISqlAsciiCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar LeftTrim(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNChar NChar(this ISqlIntegerType integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt PatternIndex(this ISqlNonMaxCharacterStringType value, Text pattern)
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt PatternIndex(this ISqlMaxCharacterStringType value, Text pattern)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar QuoteName(
            this ISqlCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar QuoteName(
            this ISqlCharacterStringType value,
            Text quoteCharacter)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Replace(
            this ISqlAsciiCharacterStringType value,
            ISqlAsciiCharacterStringType textToFind,
            ISqlAsciiCharacterStringType textToReplace)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Replace(
            this ISqlAsciiCharacterStringType value,
            ISqlUnicodeCharacterStringType textToFind,
            ISqlAsciiCharacterStringType textToReplace)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Replace(
            this ISqlAsciiCharacterStringType value,
            ISqlAsciiCharacterStringType textToFind,
            ISqlUnicodeCharacterStringType textToReplace)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Replace(
            this ISqlAsciiCharacterStringType value,
            ISqlUnicodeCharacterStringType textToFind,
            ISqlUnicodeCharacterStringType textToReplace)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Replace(
            this ISqlUnicodeCharacterStringType value,
            ISqlCharacterStringType textToFind,
            ISqlCharacterStringType textToReplace)
        {
            throw new NotInExpressionException();
        }

        public static SqlChar Replicate(this SqlChar value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlNChar Replicate(this SqlNChar value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Replicate(this SqlVarchar value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Replicate(this SqlNVarchar value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarcharMax Replicate(this SqlVarcharMax value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarcharMax Replicate(this SqlNVarcharMax value, Integer numberOfReplications)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Reverse(this ISqlAsciiCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Reverse(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Right(this ISqlAsciiCharacterStringType value, Integer integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Right(this ISqlUnicodeCharacterStringType value, Integer integer)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar RightTrim(this ISqlAsciiCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar RightTrim(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Soundex(this ISqlCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Space(this ISqlIntegerType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Str(this ISqlFloatType value, Integer length, Integer decimals)
        {
            throw new NotInExpressionException();
        }

        public static T Stuff<T>(this T value, Integer start, Integer length, Text replaceWith)
            where T : ISqlCharacterStringType
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Substring(this ISqlAsciiCharacterStringType value, Integer start, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Substring(this SqlText value, Integer start, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Substring(this ISqlUnicodeCharacterStringType value, Integer start, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Substring(this SqlNText value, Integer start, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary Substring(this ISqlBinaryType value, Integer start, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Unicode(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar Upper(this ISqlAsciiCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar Upper(this ISqlUnicodeCharacterStringType value)
        {
            throw new NotInExpressionException();
        }
    }
}
