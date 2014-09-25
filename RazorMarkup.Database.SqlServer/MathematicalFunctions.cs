using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class MathematicalFunctions
    {
        public static T Abs<T>(this T value)
            where T : ISqlNumericType
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Acos(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Asin(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Atan(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Atn2(this ISqlFloatType value, Float value2)
        {
            throw new NotInExpressionException();
        }

        public static T Ceiling<T>(this T value)
            where T : ISqlFloatType
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Cos(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Cot(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static T Degrees<T>(this T value)
            where T : ISqlNumericType
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Exp(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static T Floor<T>(this T value)
            where T : ISqlFloatType
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Log(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Log(this ISqlFloatType value, Integer @base)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Log10(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Pi()
        {
            throw new NotInExpressionException();
        }

        public static T Power<T>(this T value, Numeric y)
            where T : ISqlFloatType
        {
            throw new NotInExpressionException();
        }

        public static T Radians<T>(this T value)
           where T : ISqlNumericType
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Rand()
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Rand(SmallerInteger seed)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlTinyInt value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlSmallInt value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlInt value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt Round(this SqlBigInt value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal Round(this SqlDecimal value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal Round(this SqlNumeric value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlMoney Round(this SqlMoney value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney Round(this SqlSmallMoney value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Round(this SqlFloat value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Round(this SqlReal value, Integer length)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlTinyInt value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlSmallInt value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Round(this SqlInt value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt Round(this SqlBigInt value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal Round(this SqlDecimal value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal Round(this SqlNumeric value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlMoney Round(this SqlMoney value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney Round(this SqlSmallMoney value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Round(this SqlFloat value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Round(this SqlReal value, Integer length, Bool isTruncated)
        {
            throw new NotInExpressionException();
        }
        
        public static SqlBigInt Sign(this SqlBigInt value)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Sign(this SqlInt value)
        {
            throw new NotInExpressionException();
        }
        
        public static SqlInt Sign(this SqlSmallInt value)
        {
            throw new NotInExpressionException();
        }
        
        public static SqlInt Sign(this SqlTinyInt value)
        {
            throw new NotInExpressionException();
        }

        public static SqlMoney Sign(this SqlMoney value)
        {
            throw new NotInExpressionException();
        }

        public static SqlMoney Sign(this SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric Sign(this SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal Sign(this SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Sign(this SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal Sign(this SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Sin(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Sqrt(this ISqlNumericType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Square(this ISqlNumericType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat Tan(this ISqlFloatType value)
        {
            throw new NotInExpressionException();
        }
    }
}
